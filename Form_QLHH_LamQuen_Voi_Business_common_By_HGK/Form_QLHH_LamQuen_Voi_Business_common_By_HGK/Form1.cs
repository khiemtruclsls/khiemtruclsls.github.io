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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Business.ProductBN bProd = new Business.ProductBN();
        Business.CategoryBN CateG = new Business.CategoryBN();
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Category frm = new Form_Category();
            frm.ShowDialog();
        }
        void clear()
        {
            txtNameID.Text = "";
            txtNameProd.Text = "";
            txtPriceProd.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNameID.Text == "")
            {
                if (string.IsNullOrWhiteSpace(txtNameProd.Text))
                {
                    MessageBox.Show("PHai nhap product name :");
                    txtNameProd.Focus();
                    return;
                }
                try {
                    bProd.ThemDuLieu(txtNameProd.Text, int.Parse(txtPriceProd.Text),(int)cbCategory.SelectedValue);
                    MessageBox.Show("Them du lieu thanh cong");
                    clear();
                    }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNameProd.Text))
                {
                    MessageBox.Show("Phai nhap product name ! ");
                    txtNameProd.Focus();
                    return;
                }
                try
                {
                    bProd.CapNhatDuLieu(int.Parse(txtNameID.Text), txtNameProd.Text, int.Parse(txtPriceProd.Text), (int)cbCategory.SelectedValue);
                    MessageBox.Show("Sua du lieu thanh cong!");
                    clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = CateG.LayTatCaSanPham();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            dgvProdList.DataSource = bProd.LayTatCaSanPham();
        }

        private void dgvProdList_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvProdList.SelectedCells.Count > 0) {
                    Common.ProductCM p = (Common.ProductCM)dgvProdList.SelectedCells[0].OwningRow.DataBoundItem;
                    txtNameID.Text = p.Id.ToString();
                    txtNameProd.Text = p.Name.ToString();
                    txtPriceProd.Text = p.Price.ToString();
                    cbCategory.SelectedValue = p.CateID;
                }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if (dgvProdList.SelectedCells.Count > 0)
            {
                Common.ProductCM p = (Common.ProductCM)dgvProdList.SelectedCells[0].OwningRow.DataBoundItem;
                bProd.XoaDuLieu(p);
                MessageBox.Show("Xoa Thanh Cong");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
