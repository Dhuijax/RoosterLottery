using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client.FromLs
{
    public partial class Register : Form
    {
        string backendUrl = ConfigurationManager.AppSettings["BackendUrl"];
        private static readonly HttpClient client = new HttpClient();
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void click_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var parameter = new
            {
                Name = txtFullname.Text,
                DateOfBirth = txtBirthday.Value,
                PhoneNumber = txtPhone.Text,
                Email = txtEmail.Text,
                Password = txtPass.Text,
            };

            var requestBody = new
            {
                StoreName = "RegisterUser",
                Parameters = parameter
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(backendUrl, content);

            var responseBody = await response.Content.ReadAsStringAsync();

            responseBody = responseBody.Replace("[", "").Replace("]", "");
            try
            {
                if (!string.IsNullOrEmpty(responseBody))
                {
                    dynamic jsonArray = JsonConvert.DeserializeObject(responseBody)!;

                    var ErrorDesc = jsonArray.Error;
                    var ErrorCode = jsonArray.Code;

                    if (ErrorCode == "000")
                    {
                        MessageBox.Show("Đăng ký thành công!");
                    }
                    else
                    {
                        MessageBox.Show($"Đăng ký thất bại! Lỗi: {ErrorDesc}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng ký thất bại! Lỗi: {ex.Message}");
            }
        }
    }
}
