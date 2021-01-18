using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_By_HGK;

namespace Quan_Ly_SV_From_By_HGK
{
    public partial class LopHoc_Form : Form
    {
        public LopHoc_Form()
        {
            InitializeComponent();
        }
        BN_LopHoc lh = new BN_LopHoc();

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (lh.TheMoiLopHoc(txtCode.Text))
                {
                    MessageBox.Show("Them moi Lop hoc thanh cong! ");
                    resetdulieu();
                    return;
                }
                else
                {
                    MessageBox.Show("Co loi khi them moi lop hoc!");
                  
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi them moi lop hoc: " + ex.Message);
              
            }
        }
        void resetdulieu()
        {
            dgvLopHoc.DataSource = lh.LayTatCaLopHocTable();
        }
    }
}
