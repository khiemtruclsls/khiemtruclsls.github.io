using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Model_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Car_Model_Form\Car_Model_Form\cardb.mdf;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable tbl = new DataTable();
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sb = new SqlCommandBuilder(sda);
            sda.InsertCommand = sb.GetInsertCommand();
            sda.UpdateCommand = sb.GetUpdateCommand();
            sda.DeleteCommand = sb.GetDeleteCommand();
            sda.Update(tbl);
            RefreshDuLieu();

        }
        void RefreshDuLieu()
        {
            sda = new SqlDataAdapter("SELECT * FROM Car", scon);
            tbl = new DataTable();
            sda.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDuLieu();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RefreshDuLieu();
        }
    }
}
