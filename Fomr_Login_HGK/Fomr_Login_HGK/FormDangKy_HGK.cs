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
    public partial class FormDangKy_HGK : Form
    {
        public FormDangKy_HGK()
        {
            InitializeComponent();
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
            }
            else
            {
                User u = new User();
                u.UserName = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.FullName = txtFullName.Text;
                u.DOB = dtpDOB.Value;
                u.Sex = rdoSexFemale.Checked ? "Female" : rdoSexMale.Checked ? "Male" : "Other";
                // Biểu thức tam phân Điều kiện ? giá trị Đúng : giá trị sai 
                u.Address = txtAddress.Text;
                List<User> list = new List<User>();
                list.Add(u);   
                String jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                System.IO.File.WriteAllText("data.json", jsonData, Encoding.UTF8);
                MessageBox.Show("Thanh cong ");
                this.Close();
               

            }

        }

        private void FormDangKy_HGK_Load(object sender, EventArgs e)
        {
          
        }
    }
}
