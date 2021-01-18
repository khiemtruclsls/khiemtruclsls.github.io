using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fomr_Login_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstDanhSachNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(lstDanhSachNguoiDung.SelectedIndex >= 0)
            {
                User u = (User)lstDanhSachNguoiDung.SelectedItem;
                txtUsername.Text = u.UserName;
                txtPassword.Text = u.Password;
                txtFullName.Text = u.FullName;
                txtAddress.Text = u.Address;
                switch (u.Sex)
                {
                    case "Male" :
                        rdoSexMale.Checked = true;
                        break;
                    case "Female":
                        rdoSexFemale.Checked = true;
                        break;
                    case "Other":
                        rdoSexOther.Checked = true;
                        break;
                }
                dtpDOB.Value = u.DOB;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username : Syntax error or blank ");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password : Syntax error or blank");
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name : Syntax error or blank");
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address: Syntax error or blank");
                txtAddress.Focus();
                return;       
            }else
            {
                User u = new User();
                u.UserName = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.FullName = txtFullName.Text;
                u.DOB = dtpDOB.Value;
                u.Sex = rdoSexFemale.Checked ? "Female" : rdoSexMale.Checked ? "Male" : "Other";
                // Biểu thức tam phân Điều kiện ? giá trị Đúng : giá trị sai 
                u.Address = txtAddress.Text;
                lstDanhSachNguoiDung.Items.Add(u);
                MessageBox.Show("Thanh cong ");
                ClearTextBox();
                StatusSoluong();
            }
           

        }
        void ClearTextBox()
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
            txtFullName.Text = null;
            dtpDOB.Value = DateTime.Now;
            txtAddress.Text = null;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            StatusSoluong();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDanhSachNguoiDung.SelectedIndex >= 0)
            {
                User u = (User)lstDanhSachNguoiDung.SelectedItem;
                lstDanhSachNguoiDung.Items.Remove(u);
                ClearTextBox();
                StatusSoluong();

            }
        }

        void StatusSoluong()
        {
            lblBottom.Text = lstDanhSachNguoiDung.Items.Count.ToString();

        }

       
      

       
        //đọc dữ liệu từ file data.json 
        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string jsonData = System.IO.File.ReadAllText("data.json", Encoding.UTF8);
            List<User> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(jsonData);
            foreach (User u in list)
                lstDanhSachNguoiDung.Items.Add(u);
            MessageBox.Show("Data loaded successfully!");
            StatusSoluong();

        }
        //Lưu vào File data.json 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<User> list = new List<User>();
            foreach (object o in lstDanhSachNguoiDung.Items)
            {
                list.Add((User)o);
            }
            String jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            System.IO.File.WriteAllText("data.json", jsonData, Encoding.UTF8);
            MessageBox.Show("Data saved successfully!!!!");
            StatusSoluong();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
              FormLogin_HGK k = new FormLogin_HGK();
                k.ShowDialog();
                if (!k.LoginSuccess )
                {

                    this.Close();
                }
        }
    }
}
