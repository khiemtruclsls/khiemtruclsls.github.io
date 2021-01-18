using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_TuDien_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            //https://api.tracau.vn/WBBcwnwQpV89/s/Love/en
            HttpClient client = new HttpClient();

            string jsonData = client.GetStringAsync(string.Format("https://api.tracau.vn/WBBcwnwQpV89/s/{0}/en", txtSearch.Text)).Result;
           VI vi = Newtonsoft.Json.JsonConvert.DeserializeObject<VI>(jsonData);
            string tracau = "";
            tracau += vi.language + "*****";
            
            foreach(Sentence value in vi.sentences)
            {
                tracau += value.fields.vi.ToString() + "******";
              
            }
            foreach(object value in vi.tratu)
            {
                tracau += value.ToString();
            }
           // textBox1.Text = Regex.Replace(tracau, "<.*?>", string.Empty);
          textBox1.Text = tracau.ToString();
       
        }
    
    }
}
