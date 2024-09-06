using Newtonsoft.Json;
using System.Text;
using Client.Models;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Configuration;
using System.Text.Json.Nodes;
using Client.Apis;
using Client.Utils;
using System.Data;

namespace Client.FromLs
{
    public partial class Home : Form
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private System.Windows.Forms.Timer _timer;
        private TimeSpan _timeLeft;
        private static readonly HttpClient client = new HttpClient();
        //Phân trang Slot
        private int pageSize = 12;
        private int pageNumber = 1;
        private int totalPage = 0;
        private DataTable dataSourceSlot;
        //Phân trang Bet
        private int totalPage1 = 0;
        private int pageNumber1 = 1;
        private DataTable dataSourceBet;
        public Home()
        {
            InitializeComponent();
            LoadUserInfor();
            LoadLabelBet();
            LoadRemainingTime();
            InitializeCountdown();
            Insert_update_result();
            LoadData();
            LoadDataBet();
        }
        //Tải 2 label vòng quay
        private async void LoadLabelBet()
        {
            var parameter = new { };
            var Get_Set_Slot = new
            {
                StoreName = "Get_Set_Slot",
                Parameters = parameter
            };

            var content = new StringContent(JsonConvert.SerializeObject(Get_Set_Slot), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(backendUrl, content);

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");
            try
            {
                if (!string.IsNullOrEmpty(responseBody))
                {
                    dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;

                    lbResult.Text = jsonArray?.SlotTime + " Kết quả: " + jsonArray?.ResultNumber;
                    lbNow.Text = "Kỳ " + jsonArray?.Times + ": ";
                    lbNext.Text = "Kỳ " + jsonArray?.NextTime + ": ";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả kỳ trước!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ĐKhông tìm thấy kết quả kỳ trước! Lỗi: {ex.Message}");
            }
        }
        //Tải thông tin người dùng
        public async void LoadUserInfor()
        {

            var parameter = new
            {
                phoneNo = Environment.GetEnvironmentVariable("phoneNo")
            };
            var getInfor = new
            {
                StoreName = "Get_Infor",
                Parameters = parameter
            };

            var content = new StringContent(JsonConvert.SerializeObject(getInfor), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(backendUrl, content);

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");
            try
            {
                if (!string.IsNullOrEmpty(responseBody))
                {
                    dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;

                    txtFullname.Text = jsonArray?.Name;
                    txtBirthday.Text = ((string)jsonArray?.DateOfBirth).Substring(0, 10);
                    txtPhone.Text = Environment.GetEnvironmentVariable("phoneNo");
                    txtEmail.Text = jsonArray?.Email;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tải thông tin người dùng thất bại! Lỗi: {ex.Message}");
            }
        }
        //Tắt ứng dụng
        private void click_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        //Mở trang mua vé
        private void btnBet_Click(object sender, EventArgs e)
        {
            Bet bet = new Bet();
            bet.Show();
            this.Hide();
        }

        private async void LoadRemainingTime()
        {
            var helper = new Helper(client);
            var parameter = new { };
            var Get_maxSlot = new
            {
                StoreName = "Get_cdTime",
                Parameters = parameter
            };
            var response = await client.PostAsync(backendUrl,
                new StringContent(JsonConvert.SerializeObject(Get_maxSlot), Encoding.UTF8, "application/json"));

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");

            if (responseBody is string str && !string.IsNullOrEmpty(str))
            {
                dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;
                //int remainingSeconds = jsonArray?.RemainingTime;
                DateTime lastUpdated = jsonArray?.LastUpdated;

                DateTime newTime = DateTime.Now.AddHours(1);

                // Làm tròn thời gian hiện tại đến giờ
                DateTime roundedNow = new DateTime(
                    newTime.Year,
                    newTime.Month,
                    newTime.Day,
                    newTime.Hour,
                    0,
                    0,
                    0,
                    newTime.Kind
                );

                //TimeSpan timeElapsed = DateTime.Now - lastUpdated;
                TimeSpan timeElapsed = roundedNow - DateTime.Now;
                int remainingSeconds = (int)timeElapsed.TotalSeconds;

                if (remainingSeconds <= 0)
                {
                    _timeLeft = TimeSpan.FromMinutes(60);
                }
                else
                {
                    _timeLeft = TimeSpan.FromSeconds(remainingSeconds);
                }
            }
            else
            {
                _timeLeft = TimeSpan.FromMinutes(60);
                helper.InsertInitialRecord(_timeLeft);
            }
        }
        //Cập nhật đếm ngược cho label
        private void InitializeCountdown()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // 1 giây
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var helper = new Helper(client);

            _timeLeft = _timeLeft.Subtract(TimeSpan.FromSeconds(1));
            Environment.SetEnvironmentVariable("timeLeft", _timeLeft.TotalSeconds.ToString());
            if (_timeLeft.TotalSeconds <= 0)
            {
                _timeLeft = TimeSpan.FromMinutes(60); // Reset lại về 60 phút
                helper.UpdateDatabase();
                LotteryRandom();
                LoadLabelBet();
            }

            UpdateLabel();
            helper.UpdateDatabase();
        }
        //Xổ số
        private async void LotteryRandom()
        {

            var parameter = new { };
            var Get_maxSlot = new
            {
                StoreName = "Lottery_Random",
                Parameters = parameter
            };
            var response = await client.PostAsync(backendUrl,
                new StringContent(JsonConvert.SerializeObject(Get_maxSlot), Encoding.UTF8, "application/json"));

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");

            dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;
            if (jsonArray != null)
            {
                lbNow.Text = "Kỳ " + jsonArray?.Times + ": ";
                MessageBox.Show("Kết quả xổ số kỳ " + jsonArray?.Times + ": " + jsonArray?.ResultNumber);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        //Tự động xổ số time offline
        private async void Insert_update_result()
        {

            var parameter = new { };
            var Get_maxSlot = new
            {
                StoreName = "Auto_insert_result",
                Parameters = parameter
            };
            var response = await client.PostAsync(backendUrl,
                new StringContent(JsonConvert.SerializeObject(Get_maxSlot), Encoding.UTF8, "application/json"));

            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("[", "").Replace("]", "");

            dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;
            if (jsonArray != null)
            {
                lbNow.Text = "Kỳ " + jsonArray?.Times + ": ";
                MessageBox.Show("Kết quả xổ số kỳ " + jsonArray?.Times + ": " + jsonArray?.ResultNumber);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        //Cập nhật label đếm ngược
        private void UpdateLabel()
        {
            lbCd.Text = _timeLeft.ToString(@"mm\:ss");
        }
        public async void LoadDataBet()
        {
            var apiService = new ServiceBet(client);
            dataSourceBet = await apiService.GetBetsAsync();

            if (dataSourceBet != null)
            {
                totalPage1 = (int)Math.Ceiling(dataSourceBet.Rows.Count / (double)pageSize);
                DisplayPageBet(pageNumber1);
            }
            else
            {
                MessageBox.Show("Failed to load data.");
            }
        }
        private async void LoadData()
        {
            var slotService = new ServiceSlot(client);

            dataSourceSlot = await slotService.GetSlotsAsync();
            totalPage = (int)Math.Ceiling(dataSourceSlot.Rows.Count / (double)pageSize);
            DisplayPage(pageNumber);

        }
        private void DisplayPage(int page)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dataSourceSlot.Rows.Count);
            DataTable pageData = dataSourceSlot.Clone();

            for (int i = startIndex; i < endIndex; i++)
            {
                pageData.ImportRow(dataSourceSlot.Rows[i]);
            }

            dtgvHisResult.DataSource = pageData;
            dtgvHisResult.RowHeadersVisible = false;
            lblPageNumber.Text = $"Trang {page}/{totalPage}";
        }
        private void DisplayPageBet(int page)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dataSourceBet.Rows.Count);
            DataTable pageData = dataSourceBet.Clone();

            for (int i = startIndex; i < endIndex; i++)
            {
                pageData.ImportRow(dataSourceBet.Rows[i]);
            }

            dtgvHisBet.DataSource = pageData;
            dtgvHisBet.RowHeadersVisible = false;
            lbBetPage.Text = $"Trang {page}/{totalPage1}";
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                DisplayPage(pageNumber);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < totalPage)
            {
                pageNumber++;
                DisplayPage(pageNumber);
            }
        }

        private void btnBetNext_Click(object sender, EventArgs e)
        {
            if (pageNumber1 > 1)
            {
                pageNumber1--;
                DisplayPageBet(pageNumber1);
            }
        }

        private void btnBetPre_Click(object sender, EventArgs e)
        {
            if (pageNumber1 < totalPage1)
            {
                pageNumber1++;
                DisplayPageBet(pageNumber1);
            }
        }
    }
}
