using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_SV_From_By_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LopHoc_Click(object sender, EventArgs e)
        {
            LopHoc_Form lhf = new LopHoc_Form();
            lhf.MdiParent = this;
            lhf.Show();
        }

        private void MonHoc_Click(object sender, EventArgs e)
        {
            MonHocFRorm mhf = new MonHocFRorm();
            mhf.MdiParent = this;
            mhf.Show();
        }

        private void SinhVIen_click(object sender, EventArgs e)
        {
            SinhVien_Form svf = new SinhVien_Form();
            svf.MdiParent = this;
            svf.Show();
        }

        private void Diem_click(object sender, EventArgs e)
        {
            diem_form df = new diem_form();
            df.MdiParent = this;
            df.Show();
        }
    }
}
