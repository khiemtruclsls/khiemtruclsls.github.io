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
    public partial class SinhVien_From : Form
    {
        public SinhVien_From()
        {
            InitializeComponent();
        }
        Business_By_HGK.BN_LopHoc lh = new Business_By_HGK.BN_LopHoc();
        Business_By_HGK.BN_SinhVien sv = new Business_By_HGK.BN_SinhVien();
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refreshDuLieu();
        }

        private void SinhVien_From_Load(object sender, EventArgs e)
        {
            refreshDuLieu();
        }
        void refreshDuLieu()
        {
            cbLopHoc.DataSource = lh.LayTatCaLopHocTable();
            cbLopHoc.ValueMember = "Id";
            cbLopHoc.DisplayMember = "Code";
            dgvSinhVien.DataSource = sv.TimSinhVienTable(txtSearch.Text);

        }
    }
}
