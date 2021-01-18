using Form_ET_dathang_HGK.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ET_dathang_HGK
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        BN_Prod pt = new BN_Prod();
        BN_Cate ct = new BN_Cate();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameProd.Text))
            {
                MessageBox.Show("Please enter Name Prod .....");
            }
            if (string.IsNullOrWhiteSpace(txtPriceProd.Text))
            {
                MessageBox.Show("Please enter Price Prod .....");
            }
            if (string.IsNullOrWhiteSpace(txtIdProd.Text))
            {
                pt.themmoidulieu(txtNameProd.Text , int.Parse(txtPriceProd.Text),(int)cbcateName.SelectedValue );
                MessageBox.Show("Successfully added new data");
                clear();
                refreshDL();
            }
            else
            {
                pt.SuaProdut(int.Parse(txtIdProd.Text), txtNameProd.Text, int.Parse(txtPriceProd.Text), (int)cbcateName.SelectedValue);
                MessageBox.Show("Successful data correction");
                refreshDL();
            }
        }
        void clear()
        {
            txtIdProd.Text = "";
            txtNameProd.Text = "";
            txtPriceProd.Text = "";
        }
        void refreshDL()
        {
            dgvProd.DataSource = pt.laytatcaProduct();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            cbcateName.DataSource = ct.LayTatCaCategory();
            cbcateName.DisplayMember = "Name";
            cbcateName.ValueMember = "Id";
           
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshDL();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdProd.Text))
            {
                pt.xoadl(int.Parse(txtIdProd.Text));
                clear();
                refreshDL();
                MessageBox.Show("detele data successful");
            }
        }

        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProd.SelectedCells.Count <= 0) return;
            Product pt = (Product)dgvProd.SelectedCells[0].OwningRow.DataBoundItem;
            txtIdProd.Text = pt.Id.ToString();
            txtNameProd.Text = pt.Name;
            txtPriceProd.Text = pt.Price.ToString();
            cbcateName.SelectedValue = pt.CateId;
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
