using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting_Game_HGK
{
    public partial class fmKetQua : Form
    {
        public fmKetQua()
        {
            InitializeComponent();
        }
   
        public List<Nguoichoi> DsKetqua { get; set; }
        private void fmKetQua_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DsKetqua;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
