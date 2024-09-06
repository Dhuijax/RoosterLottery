using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utils
{
    public class Helper
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private System.Windows.Forms.Timer _timer;
        private TimeSpan _timeLeft;
        private readonly HttpClient _client;
        public Helper(HttpClient client)
        {
            _client = client;
        }
        public async void UpdateDatabase()
        {

            var parameter = new
            {
                RemainingTime = Environment.GetEnvironmentVariable("timeLeft"),//_timeLeft.TotalSeconds.ToString()
                LastUpdated = DateTime.Now,
            };
            var Get_maxSlot = new
            {
                StoreName = "Insert_cdTime",
                Parameters = parameter
            };
            var response = await _client.PostAsync(backendUrl,
                new StringContent(JsonConvert.SerializeObject(Get_maxSlot), Encoding.UTF8, "application/json"));

            //var responseBody = await response.Content.ReadAsStringAsync();
            //responseBody = responseBody.Replace("[", "").Replace("]", "");

            //dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;
            //if (jsonArray != null)
            //{
            //    Console.WriteLine("OKAY");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //}
        }

        public async void InsertInitialRecord(TimeSpan timeLeft)
        {

            var parameter = new
            {
                RemainingTime = timeLeft.TotalSeconds.ToString(),
                LastUpdated = DateTime.Now,
            };
            var Get_maxSlot = new
            {
                StoreName = "Insert_cdTime",
                Parameters = parameter
            };
            var response = await _client.PostAsync(backendUrl,
                new StringContent(JsonConvert.SerializeObject(Get_maxSlot), Encoding.UTF8, "application/json"));

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");

            dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;
            if (jsonArray != null)
            {
                Console.WriteLine("OKAY");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        public static TimeSpan RoundToNearestHour(TimeSpan timeSpan)
        {
            // Tính số phút đã qua trong TimeSpan
            double totalMinutes = timeSpan.TotalMinutes;
            // Làm tròn đến giờ gần nhất
            double roundedHours = Math.Round(totalMinutes / 60.0);
            return TimeSpan.FromHours(roundedHours);
        }
    }
}
