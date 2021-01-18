using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_HGK
{
    public partial class Calculator_By_HGK : Form
    {
        public Calculator_By_HGK()
        {
            InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double kq=0;
        int set;
       

        private void Button_Click_ip(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPheptinh.Text += btn.Text;
           
        }

        

        private void button14_Click(object sender, EventArgs e)
        {
            if(txtPheptinh.Text == "")
            {
                txtPheptinh.Text = "";
                MessageBox.Show("Please enter");
            }
            switch (set)
            {
                case 1:

                    if (txtPheptinh.Text == "")
                    {
                        b = 0;
                        kq = a + b;
                        txtPheptinh.Text = kq.ToString();
                    }
                    else 
                    {
                        b = double.Parse(txtPheptinh.Text);
                        kq = a + b;
                        txtPheptinh.Text = kq.ToString();

                        lstKetQua.Items.Add(a +"+"+ b + "=" + kq);
                        StatusSoLuong();
                    }
                    break;
                case 2:
                    if (txtPheptinh.Text == "")
                    {
                        b = 0;
                        kq = a + b;
                        txtPheptinh.Text = kq.ToString();
                    }
                    else
                    {
                        b = double.Parse(txtPheptinh.Text);
                        kq = a - b;
                        txtPheptinh.Text = kq.ToString();
                        lstKetQua.Items.Add(a + "-"+ b + "=" + kq);
                        StatusSoLuong();
                    }
                   // b = double.Parse(txtPheptinh.Text);
                  ///  kq = a - b;
                  //  txtPheptinh.Text = kq.ToString();
                    break;
                case 3:
                    if (txtPheptinh.Text == "")
                    {
                        b = 0;
                        kq = a + b;
                        txtPheptinh.Text = kq.ToString();

                    }
                    else
                    {
                        b = double.Parse(txtPheptinh.Text);
                        kq = a * b;
                        txtPheptinh.Text = kq.ToString();
                        lstKetQua.Items.Add(a + "x" +b + "=" + kq);
                        StatusSoLuong();

                    }
                    
                    break;
                case 4:
                    if (txtPheptinh.Text == "")
                    {
                        b = 0;
                        kq = a + b;
                        txtPheptinh.Text = kq.ToString();
                    }
                    else
                    {
                        b = double.Parse(txtPheptinh.Text);
                        kq = a / b;
                        txtPheptinh.Text = kq.ToString();
                        lstKetQua.Items.Add(a + ":" + b + "=" + kq);
                        StatusSoLuong();

                    }
                    break;
                   
            }
        }
        //CỘng
        private void button17_Click(object sender, EventArgs e)
        {   
           
            if (txtPheptinh.Text != "")
            {
                a = double.Parse(txtPheptinh.Text);
                txtPheptinh.Text = "";
                set = 1;
               
               

            }
            else if(txtPheptinh.Text == "")
            {
                a = 0;
                txtPheptinh.Text = "";
                set = 1;
                
            }
          

        }
        //trừ
        private void button16_Click(object sender, EventArgs e)
        {
            if (txtPheptinh.Text == "")
            {
                a = 0;
                txtPheptinh.Text = "";
                set = 2;
            }
            else
            {
                a = double.Parse(txtPheptinh.Text);
                txtPheptinh.Text = "";
                set = 2;
            }

        }
        //nhân
        private void button13_Click(object sender, EventArgs e)
        {
            if (txtPheptinh.Text == "")
            {
                a = 0;
                txtPheptinh.Text = "";
                set = 3;
            }
            else
            {
                a = double.Parse(txtPheptinh.Text);
                txtPheptinh.Text = "";
                set = 3;
            }
        }
        //chia
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPheptinh.Text == "")
            {
                a = 0;
                txtPheptinh.Text = "";
                set = 4;
            }
            else
            {
                a = double.Parse(txtPheptinh.Text);
                txtPheptinh.Text = "";
                set = 4;
            }
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            kq = 0;
            txtPheptinh.Text = ""; 
        }
        private void button14_KeyDown(object sender, KeyEventArgs e)
        {
      /*      if(e.KeyCode == Keys.Enter)
            {
                button14_Click(sender,e);
            }*/
        }
        private void Button_List(object sender, EventArgs e)
        {
            if (lstKetQua.SelectedIndex >= 0)
            {
                txtPheptinh.Text = lstKetQua.SelectedItem.ToString();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void StatusSoLuong()
        {
            lblBottomText.Text = "So luong phep tinh : " + lstKetQua.Items.Count.ToString();
        }
      

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //ĐỌc dữ liệu từ FIle 
            string[] dulieu = System.IO.File.ReadAllLines("data.txt");
            //Bỏ hết dữ liệu cũ ở bảng 
            lstKetQua.Items.Clear();
            //Dữ lieuejj đưa vào bảng 
            foreach (object o in dulieu)
                lstKetQua.Items.Add(o);
            lblBottomText.Text = "So luong phep tinh : " + lstKetQua.Items.Count.ToString();
            MessageBox.Show("load du lieu thanh cong !!!");
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(object o in lstKetQua.Items)
            {
                sb.AppendLine(o.ToString());

            }
            System.IO.File.WriteAllText("data.txt", sb.ToString());
            MessageBox.Show("Lua thanh cong !!!!");
        }
    }
}
