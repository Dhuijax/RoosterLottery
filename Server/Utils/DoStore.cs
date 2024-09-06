using System.Data;
using Microsoft.Data.SqlClient;

namespace Server.Utils
{
    public class DoStore
    {
            private readonly string _connectionString;
            public DoStore(string connectionString)
            {
                _connectionString = connectionString;
            }

        public async Task<DataTable> ExecuteAsync(string store, Dictionary<string, string> parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync(); // Mở kết nối bất đồng bộ

                using (SqlCommand command = new SqlCommand(store, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue("@" + param.Key, param.Value ?? string.Empty);
                        }
                    }

                    DataTable result = new DataTable();

                    // Sử dụng SqlDataReader bất đồng bộ
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        // Nạp cấu trúc bảng từ SqlDataReader
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                        }

                        // Nạp dữ liệu vào DataTable
                        while (await reader.ReadAsync())
                        {
                            DataRow row = result.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
                            result.Rows.Add(row);
                        }
                    }

                    return result; // Trả về DataTable đã load dữ liệu
                }
            }
        }
    }
}
