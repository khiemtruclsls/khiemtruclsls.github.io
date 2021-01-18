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
    public partial class FormLietkedanhsachorder : Form
    {
        public FormLietkedanhsachorder()
        {
            InitializeComponent();
        }

        private void dgvOder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SimpleEntities db = new SimpleEntities();
        private void dgvOder_SelectionChanged(object sender, EventArgs e)
        {
            //  dgvOrder.DataSource = db.Orders.ToList();
            if (dgvOder.SelectedCells.Count <= 0) return;
            Order o = (Order)dgvOder.Rows[dgvOder.SelectedCells[0].RowIndex].DataBoundItem;
            dgvOrderPRoduct.DataSource = o.OrderProducts.ToList();
        }

        private void FormLietkedanhsachorder_Load(object sender, EventArgs e)
        {
            dgvOrderPRoduct.AutoGenerateColumns = false;
            List<Order> list = db.Orders.ToList();
            foreach(Order o in list)
            {
                o.OrderProducts = db.OrderProducts.Where(op => op.OrderId == o.Id).ToList();
                foreach(OrderProduct op1 in o.OrderProducts)
                {
                    op1.Product = db.Products.Find(op1.ProductId);
                }
            }

            dgvOder.DataSource = db.Orders.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dgvOder.DataSource = db.Orders.ToList();
        }
    }
}
