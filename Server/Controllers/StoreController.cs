using Microsoft.AspNetCore.Mvc;
using Server.Models;
using System.Data;
using Server.Utils;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly DoStore _doStore;
        public StoreController(DoStore doStore)
        {
            _doStore = doStore;
        }

        [HttpPost("doStore")]
        public async Task<IActionResult> ExecuteStore([FromBody] Store request)
        {
            try
            {
                var parameters = new Dictionary<string, string>();
                foreach (var param in request.Parameters)
                {
                    parameters.Add(param.Key, param.Value);
                }

                // Gọi hàm ExecuteAsync
                var result = await _doStore.ExecuteAsync(request.StoreName, parameters);

                // Chuyển đổi kết quả DataTable thành list dictionary
                var list = result.AsEnumerable().Select(row =>
                    row.Table.Columns.Cast<DataColumn>()
                    .ToDictionary(col => col.ColumnName, col => row[col]?.ToString())) // Xử lý null
                    .ToList();

                return Ok(list); // Trả về danh sách kết quả
            }
            catch (Exception ex)
            {
                // Bắt lỗi và trả về thông báo lỗi
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
