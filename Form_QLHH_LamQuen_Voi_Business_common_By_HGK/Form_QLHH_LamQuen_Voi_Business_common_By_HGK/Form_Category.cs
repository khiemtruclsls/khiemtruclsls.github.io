using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK
{
    public partial class Form_Category : Form
    {
        public Form_Category()
        {
            InitializeComponent();
        }
        Business.CategoryBN CateG = new Business.CategoryBN();
        void ClearForm()
        {
            txtNameID.Text = "";
            txtNameCate.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameID.Text == "")
            {
                // Them moi 1 category
                if (string.IsNullOrWhiteSpace(txtNameCate.Text))
                {
                    MessageBox.Show("Phai nhap Category Name!");
                    txtNameCate.Focus();
                    return;
                }
                try
                {
                    CateG.ThemDuLieu(txtNameCate.Text);
                    MessageBox.Show("Them moi du lieu thanh cong!");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                // Edit category theo ID da co
                // Them moi 1 category
                if (string.IsNullOrWhiteSpace(txtNameCate.Text))
                {
                    MessageBox.Show("Phai nhap Product Name!");
                    txtNameCate.Focus();
                    return;
                }
                try
                {
                    CateG.CapNhatDulieu(int.Parse(txtNameID.Text), txtNameCate.Text);
                    MessageBox.Show("Sua du lieu thanh cong!");
                    //ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void RefreshForm()
        {
            dgvCateList.DataSource = CateG.LayTatCaSanPham();
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void dgvCateList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCateList.SelectedCells.Count > 0)
            {
                Common.CategoryCM p = (Common.CategoryCM)dgvCateList.SelectedCells[0].OwningRow.DataBoundItem;
                txtNameID.Text = p.Id.ToString();
                txtNameCate.Text = p.Name.ToString();
             
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if (dgvCateList.SelectedCells.Count > 0)
            {
                Common.CategoryCM p = (Common.CategoryCM)dgvCateList.SelectedCells[0].OwningRow.DataBoundItem;
                txtNameID.Text = p.Id.ToString();
                txtNameCate.Text = p.Name.ToString();
                CateG.XoaDuLieu(p);
                ClearForm();
                MessageBox.Show("XOa thanh cong !!!!");

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
