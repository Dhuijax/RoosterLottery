using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Apis;
using Newtonsoft.Json;

namespace Client.FromLs
{
    public partial class Homeless : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly ServiceSlot api = new ServiceSlot(client);
        public Homeless()
        {
            InitializeComponent();
            LoadDataGridViewAsync();
        }

        public async void LoadDataGridViewAsync()
        {
            int maxValue = await api.ApiGetNumberAsync();

            DataTable dataTable = new DataTable();

            for (int i = 0; i < 11; i++)
            {
                dataTable.Columns.Add("Column " + (i + 1).ToString());
            }

            int rowCount = 5;
            int columnCount = 11;
            int currentValue = 0;

            for (int i = 0; i < rowCount; i++)
            {
                DataRow row = dataTable.NewRow();
                for (int j = 0; j < columnCount; j++)
                {
                    row[j] = (currentValue <= maxValue) ? currentValue.ToString("00") : "";
                    currentValue++;
                }
                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;
        }
    }
}
