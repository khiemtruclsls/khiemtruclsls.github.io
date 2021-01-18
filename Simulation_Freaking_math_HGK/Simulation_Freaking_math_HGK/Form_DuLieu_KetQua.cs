using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Freaking_math_HGK
{
    public partial class Form_DuLieu_KetQua : Form
    {
        public Form_DuLieu_KetQua()
        {
            InitializeComponent();
        }
        public List<KetQua> DSketqua { get; set; }
        private void Form_DuLieu_KetQua_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DSketqua;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null && dataGridView1.SelectedCells.Count > 0) {
                List<int> listhangcanxoa = new List<int>();
                for (int i = 0; i < dataGridView1.SelectedCells.Count;i++) {
                    listhangcanxoa.Add(dataGridView1.SelectedCells[i].RowIndex);
                }
                listhangcanxoa = listhangcanxoa.OrderByDescending(i => 1).ToList();
                foreach (int i in listhangcanxoa) {
                    int hangduocchon = i;
                    DSketqua.RemoveAt(hangduocchon);
                }
                dataGridView1.DataSource = DSketqua.ToList();
                System.IO.File.WriteAllText("ketqua.json", Newtonsoft.Json.JsonConvert.SerializeObject(DSketqua), Encoding.UTF8);
                MessageBox.Show("record deteled!");
            }
  
       
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("ketqua.json", Newtonsoft.Json.JsonConvert.SerializeObject(DSketqua), Encoding.UTF8);
            MessageBox.Show("Record edited!");
        }
    }
}
