using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Simulation_Freaking_math_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int demthoigian = 3 ;
        int sodiem = 0;
        bool loaipheptinh = true;
        int level = 1;
        private void btnChonKetQua(object sender, EventArgs e)
        {
            if ((((Button)sender).Text == "O" && loaipheptinh == true) || (loaipheptinh == false &&((Button)sender).Text == "X"))
            {
                lblMark.Text = "Mark : " + (++sodiem).ToString();
                Sinhpheptoan();
                demthoigian = 3;
                return;
            }
            GameOver();
        }
        List<KetQua> list = new List<KetQua>();
        void GameOver()
        {

            timer1.Stop();
            Form_Nguoi_Choi n = new Form_Nguoi_Choi();
            n.ShowDialog();
            KetQua kq = new KetQua() { TenNguoiChoi =n.TenNguoiChoi , SoDiem = sodiem , ThoiGianChoi = DateTime.Now};
            list.Add(kq);
            System.IO.File.WriteAllText("ketqua.json", Newtonsoft.Json.JsonConvert.SerializeObject(list), Encoding.UTF8);
            String top10 = Lay10nguoichoi();
            MessageBox.Show(string.Format("Nguoi choi : {0} \n dat so diem la : {1} \n Top 10 nguoi choi diem cao nhat : {2}",n.TenNguoiChoi,sodiem,top10));
            textBox1.Text = "1 + 3 = 4";
            loaipheptinh = true;
            sodiem = 0;
            lblMark.Text = "Mark : 0";
            demthoigian = 3;
            lbltime.Text = "Time : 3";
            level = 1;

        }
        string Lay10nguoichoi()
        {
            list = list.OrderByDescending(kq => kq.SoDiem).ToList();
            string  top10= "";
            for(int i = 0; i < ( list.Count >=10 ? 10 : list.Count ); i++)
            {
                top10 += string.Format("\n Nguoi choi : {0} \t diem : {1} \t thoi gian : {2}", list[i].TenNguoiChoi,list[i].SoDiem,list[i].ThoiGianChoi);
            }
            return top10;

        }
        Random rd = new Random();
        void Sinhpheptoan()
        {
            timer1.Stop();
            int so1 = rd.Next(10 + (int)Math.Pow(5, level - 1), 10 + (int)Math.Pow(5,level ));
            int so2 = rd.Next(10 + (int)Math.Pow(5, level - 1), 10 + (int)Math.Pow(5, level));

            string dau = "+-*:";
            int vitridau = rd.Next(0, 3);
            dau = dau[vitridau].ToString();
            double ketqua = 0;
            switch (dau)
            {
                case "+":
                    ketqua = so1 + so2;
                    break;
                case "-":
                    ketqua = so1 - so2;
                    break;
                case "*":
                    ketqua = so1 * so2;
                    break;
                case ":":
                    ketqua = so1 / so2;
                    break;
            }
            loaipheptinh = rd.Next(0, 100) >= 50;
            if (!loaipheptinh)
            {
                int saiso = 0;
                while (saiso ==0)
                {
                    saiso = rd.Next(-10, 10);
                }
                ketqua = ketqua + saiso;

            }
            textBox1.Text = string.Format("{0} {1} {2} = {3}", so1, dau, so2, ketqua);
            demthoigian = 3;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time : " + (--demthoigian).ToString();
            if(demthoigian < 0)
            {
                GameOver();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                string jsondata = System.IO.File.ReadAllText("ketqua.json", Encoding.UTF8);
                list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<KetQua>>(jsondata);
            } catch
            {
                list = new List<KetQua>();
            }
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            Form_DuLieu_KetQua kq = new Form_DuLieu_KetQua();
            kq.DSketqua = list;
            kq.ShowDialog();
        }
    }
}
