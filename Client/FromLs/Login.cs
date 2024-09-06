using Newtonsoft.Json;
using System.Text;
using Client.Utils;
using System.Configuration;

namespace Client.FromLs
{
    public partial class Login : Form
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void click_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var parameter = new
            {
                PhoneNumber = txtPhone.Text,
                Password = txtPass.Text,
            };

            var requestBody = new
            {
                StoreName = "AuthenticateUser",
                Parameters = parameter
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(backendUrl, content);

            
            var responseBody = await response.Content.ReadAsStringAsync();

            responseBody = responseBody.Replace("[","").Replace("]","");
            try
            {
                if (!string.IsNullOrEmpty(responseBody))
                {
                    dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;

                    var ErrorDesc = jsonArray.Error;
                    var ErrorCode = jsonArray.Code;

                    if (ErrorCode == "000")
                    {
                        Environment.SetEnvironmentVariable("phoneNo", txtPhone.Text);
                        MessageBox.Show("Đăng nhập thành công!");
                        Home bet = new Home();
                        bet.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Đăng nhập thất bại! Lỗi: {ErrorDesc}");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập thất bại! Lỗi: {ex.Message}");
            }
        }
    }
}
