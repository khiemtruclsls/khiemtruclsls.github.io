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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caterogyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caterogy fm = new Caterogy();
            fm.MdiParent = this;
            fm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct fm = new frmProduct();
            fm.MdiParent = this;
            fm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder fm = new frmOrder();
            fm.MdiParent = this;
            fm.Show();
        }

        private void ketquaorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLietkedanhsachorder fm = new FormLietkedanhsachorder();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
