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
    public partial class MonHocFRorm : Form
    {
        public MonHocFRorm()
        {
            InitializeComponent();
        }
        BN_MonHoc mh = new BN_MonHoc();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (mh.ThemMoiMonHoc(txtCode.Text, txtName.Text))
                {
                    MessageBox.Show("Them moi mon hoc thanh cong! ");
                   
                    RefreshDuLieu();
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
        void RefreshDuLieu()
        {
            dgvMonHoc.DataSource = mh.LayTatCaMonHocTable();
        }
    }
}
