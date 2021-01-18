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

namespace WeatherAPI_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //http://api.openweathermap.org/data/2.5/weather?q=Ho%20Chi%20Minh%20City&appid=8e1908235b6bf2bdd4bfdb4af649a714
            HttpClient client = new HttpClient();
           string jsondata = client.GetStringAsync(string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=8e1908235b6bf2bdd4bfdb4af649a714", txtSearchCity.Text)).Result;
            ThoiTiet _thoitiet = Newtonsoft.Json.JsonConvert.DeserializeObject<ThoiTiet>(jsondata);
            txtTemp.Text = _thoitiet.main.temp.ToString();
            txtHumid.Text = _thoitiet.main.humidity.ToString();
            txtWind.Text = _thoitiet.wind.speed.ToString();
            txtDegr.Text = _thoitiet.wind.deg.ToString();
            MessageBox.Show("Ket qua !!!!");
                
                }
    }
}
