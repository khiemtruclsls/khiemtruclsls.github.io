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
    public partial class FormLogin_HGK : Form
    {
        public FormLogin_HGK()
        {
            InitializeComponent();
        }
        public bool LoginSuccess { get; set; }
        List<User> list = new List<User>();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("UserName is required!!!!");
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("PassWord is required!!!!");
                txtPassword.Focus();
                return;
            }
            String jsondata = System.IO.File.ReadAllText("data.json", Encoding.UTF8);
            list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(jsondata);
            if (list.Any(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text )){
                MessageBox.Show("Login Success");
                LoginSuccess = true;
                this.Close();
                return;
            }
            MessageBox.Show("Login failed!");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_HGK_Load(object sender, EventArgs e)
        {
            LoginSuccess = false;

            try {
                String jsondata = System.IO.File.ReadAllText("data.json", Encoding.UTF8);
                list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(jsondata);
            } 
            catch { }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy_HGK k = new FormDangKy_HGK();
            k.ShowDialog();
          
           
        }
    }
}
