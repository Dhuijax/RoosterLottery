using System;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.Models;
using Client.Utils;
using Newtonsoft.Json;

namespace Client.Apis
{
    public class ServiceSlot
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private readonly HttpClient _client;

        public ServiceSlot(HttpClient client)
        {
            _client = client;
        }

        public async Task<int> ApiGetNumberAsync()
        {
            var parameter = new
            {
                varname = "maxnumber"
            };

            var requestBody = new
            {
                StoreName = "LotSysVar_SELECT",
                Parameters = parameter
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("https://localhost:44392/api/Store/doStore", content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ApiResponseItem>>(responseBody);

            if (result != null && result.Count > 0)
            {
                
                if (int.TryParse(result[0].VarValue, out int varValue))
                {
                    return varValue;
                }
                else
                {
                    throw new InvalidOperationException("varvalue is not a valid integer.");
                }
            }
            else
            {
                throw new InvalidOperationException("No data found in response.");
            }
        }

        public async Task<DataTable> GetSlotsAsync()
        {
            var parameter = new { };

            var requestBody = new
            {
                StoreName = "Get_slots_result",
                Parameters = parameter
            };
            var jsonRequest = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PostAsync(backendUrl, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var slots = JsonConvert.DeserializeObject<List<Slot>>(responseBody);

                return ConvertToDataTable(slots);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        private DataTable ConvertToDataTable(List<Slot> slots)
        {
            var table = new DataTable();

            table.Columns.Add("Lần quay", typeof(int));
            table.Columns.Add("Thời gian", typeof(string));
            table.Columns.Add("Kết quả", typeof(int));
            table.Columns.Add("Tổng vé mua", typeof(int));
            table.Columns.Add("Số vé trúng", typeof(int));
            foreach (var slot in slots)
            {
                table.Rows.Add(slot.RowNum, slot.SlotTime, slot.ResultNumber, slot.Tickets, slot.Wins);
            }

            return table;
        }
    }
}
