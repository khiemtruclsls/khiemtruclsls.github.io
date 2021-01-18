using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Freaking_math_HGK
{
    public partial class Form_Nguoi_Choi : Form
    {
        public Form_Nguoi_Choi()
        {
            InitializeComponent();
        }
        public string TenNguoiChoi
        {
            get
            {
                return textBox1.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TenNguoiChoi)) {
                textBox1.Text = "Vô Danh";
                }
            this.Close();
        }
    }
}
