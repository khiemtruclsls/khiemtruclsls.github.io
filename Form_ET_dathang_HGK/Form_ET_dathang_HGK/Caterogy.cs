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
    public partial class Caterogy : Form
    {
        public Caterogy()
        {
            InitializeComponent();
        }
        BN_Cate ct = new BN_Cate();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameCate.Text))
            {
                MessageBox.Show("Please enter Name category .....");
            }
            if (string.IsNullOrWhiteSpace(txtIDcate.Text)){
                ct.ThemMoiCategory(txtNameCate.Text);
                MessageBox.Show("Successfully added new data");
                clear();
                refreshDL();
            }
            else
            {
                ct.SuaCategory(int.Parse(txtIDcate.Text), txtNameCate.Text);
                MessageBox.Show("Successful data correction");
                refreshDL();
            }
        }
        void clear()
        {
            txtIDcate.Text = "";
            txtIDcate.Text = "";
        }
        void refreshDL()
        {
            dgvCate.DataSource = ct.LayTatCaCategory();
        }

        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIDcate.Text))
            {
                ct.XoaCategory(int.Parse(txtIDcate.Text));
                clear();
                refreshDL();
                MessageBox.Show("detele data successful");
            }
        }

        private void dgvCate_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCate.SelectedRows.Count <= 0) return;
            Category c = (Category)dgvCate.SelectedRows[0].DataBoundItem;
            txtIDcate.Text = c.Id.ToString();
            txtNameCate.Text = c.Name;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void refsehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshDL();
        }
    }
}
