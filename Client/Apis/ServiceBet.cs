using Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Apis
{
    public class ServiceBet
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private readonly HttpClient _client;
        public ServiceBet(HttpClient client)
        {
            _client = client;
        }
        public async Task<DataTable> GetBetsAsync()
        {
            var parameter = new { PhoneNumber = Environment.GetEnvironmentVariable("phoneNo") };

            var requestBody = new
            {
                StoreName = "Get_bets_result",
                Parameters = parameter
            };
            var jsonRequest = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PostAsync(backendUrl, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var bets = JsonConvert.DeserializeObject<List<Bet>>(responseBody);

                return ConvertToDataTable(bets);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        private DataTable ConvertToDataTable(List<Bet> bets)
        {
            var table = new DataTable();

            table.Columns.Add("Vòng quay", typeof(int));
            table.Columns.Add("Kết quả", typeof(string));
            table.Columns.Add("Số đã mua", typeof(int));
            table.Columns.Add("Thời gian mua", typeof(DateTime));

            foreach (var bet in bets)
            {
                string result = bet.Wol == "Y" ? "Trúng thưởng!!!" : "Chúc bạn may mắn lần sau";

                table.Rows.Add(bet.SlotID, result, bet.BetNumber, bet.BetTime);
            }

            return table;
        }

    }
}
