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
    public partial class SinhVien_Form : Form
    {
        public SinhVien_Form()
        {
            InitializeComponent();
        }
        Business_By_HGK.BN_LopHoc lh = new Business_By_HGK.BN_LopHoc();
        Business_By_HGK.BN_SinhVien sv = new Business_By_HGK.BN_SinhVien();
        private void btnSearch_Click(object sender, EventArgs e)
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

        private void SinhVien_Form_Load(object sender, EventArgs e)
        {
            refreshDuLieu();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNamSinh.Text);
          
            try
            {
                if (sv.ThemMoiSinhVien(txtRollNumber.Text, txtHoTen.Text,a, txtDiaChi.Text,txtQueQuan.Text, (int)cbLopHoc.SelectedValue))
                {
                    MessageBox.Show("Them moi mon hoc thanh cong! ");

                    refreshDuLieu();
                    return;
                }
                else
                {
                    MessageBox.Show("Co loi khi them moi mon hoc!");

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi them moi mon hoc: " + ex.Message);


            }
        }
    }
}
