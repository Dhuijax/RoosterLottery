using Client.Apis;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;

namespace Client.FromLs
{
    public partial class Bet : Form
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private static readonly HttpClient client = new HttpClient();

        
        public Bet()
        {
            InitializeComponent();
        }

        private void click_Closing(object sender, FormClosingEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private async void btnBet_Click(object sender, EventArgs e)
        {
            //Lấy lượt mở hiện tại
            var parameter1 = new { };
            var Get_maxSlot = new
            {
                StoreName = "Get_Max_Slot",
                Parameters = parameter1
            };
            var content1 = new StringContent(JsonConvert.SerializeObject(Get_maxSlot), Encoding.UTF8, "application/json");
            var response1 = await client.PostAsync(backendUrl, content1);

            var responseBody1 = await response1.Content.ReadAsStringAsync();
            responseBody1 = responseBody1.Replace("[", "").Replace("]", "");

            dynamic jsonArray1 = JsonConvert.DeserializeObject(responseBody1)!;
            string curslot = jsonArray1?.curr;
            Environment.SetEnvironmentVariable("curslot", curslot.ToString());

            //Lưu cược
            var parameter = new
            {
                PhoneNumber = Environment.GetEnvironmentVariable("phoneNo"),
                SlotID = Environment.GetEnvironmentVariable("curslot"),
                BetNumber = txtBet.Text,
            };
            var betSlot = new
            {
                StoreName = "Bet_Slot",
                Parameters = parameter
            };

            var content = new StringContent(JsonConvert.SerializeObject(betSlot), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(backendUrl, content);

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");
            try
            {
                if (!string.IsNullOrEmpty(responseBody))
                {
                    dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;

                    string status = jsonArray?.Error;
                    string code = jsonArray?.Code;
                    MessageBox.Show(status);
                }
                else
                {
                    MessageBox.Show("Mua vé thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mua vé không thành công! Lỗi: {ex.Message}");
            }
        }
    }
}
