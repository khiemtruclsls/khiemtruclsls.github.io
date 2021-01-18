using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_ChuyenDoiTIenTe_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //https://prime.exchangerate-api.com/v5/8d88560133fd964c7465caa7/latest/USD
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnchuyendoi_Click(object sender, EventArgs e)
        {
            //https://pro.exchangerate-api.com/v6/8d88560133fd964c7465caa7/pair/USD/JPY
            HttpClient client = new HttpClient();
            string jsonData = client.GetStringAsync(string.Format("https://prime.exchangerate-api.com/v5/8d88560133fd964c7465caa7/latest/USD")).Result;
            CD cd = Newtonsoft.Json.JsonConvert.DeserializeObject<CD>(jsonData);
            //cd.conversion_rates.JPY.ToString();
            txtJpy.Text = cd.conversion_rates.JPY.ToString();

        }
    }
}
