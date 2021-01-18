using Form_QLCV_BY_HGK.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLCV_BY_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bn_tt tt = new Bn_tt();
        BN.Bn_CV cv = new BN.Bn_CV();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCongViec.AutoGenerateColumns = false;
            cbtt.DataSource = tt.LayTatCaSanPham();
            cbtt.DisplayMember = "Name_tt";
            cbtt.ValueMember = "ID_tt";
            refreshdl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtidcv.Text == "") {
                if (string.IsNullOrWhiteSpace(txtNoidung.Text))
                {
                    MessageBox.Show("Phải nhập nội dung :");
                    txtNoidung.Focus();
                    return;
                }
                try
                {
                    cv.ThemDuLieu(dtpngaytao.Value, (int)cbtt.SelectedValue, dtpngayhoanthanh.Value, txtNoidung.Text);
                    MessageBox.Show("Thêm dữ liệu thành công ....");
                    refreshdl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNoidung.Text))
                {
                    MessageBox.Show("Phải nhập nội dung");
                    txtNoidung.Focus();
                    return;
                }
                try
                {
                    cv.capnhatdl(int.Parse(txtidcv.Text), dtpngaytao.Value, (int)cbtt.SelectedValue, dtpngayhoanthanh.Value, txtNoidung.Text);
                    MessageBox.Show("Sửa dữ liệu thành công...!");
                    refreshdl();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dgvCongViec_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCongViec.SelectedRows.Count <= 0) return;
            CMcongviec cv = (CMcongviec)dgvCongViec.SelectedRows[0].DataBoundItem;
            txtidcv.Text = cv.ID_Cv.ToString();
            txtNoidung.Text = cv.Noidung;
            cbtt.SelectedValue = cv.ID_TT;
            dtpngaytao.Value = cv.ngaytao;
            dtpngayhoanthanh.Value = cv.ngayhoanthanh;
           
        }

        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtidcv.Text = "";
            txtNoidung.Text = "";
            dtpngaytao.Value = DateTime.Now;
            dtpngayhoanthanh.Value = DateTime.Now;
          
        }
        void refreshdl()
        {
            dgvCongViec.DataSource = cv.laytatca();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidcv.Text))
            {
                MessageBox.Show("Chưa có ID cần xóa .....");
           
            }
            else
            {
                cv.xoadulieu(int.Parse(txtidcv.Text));
                refreshdl();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshdl();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
