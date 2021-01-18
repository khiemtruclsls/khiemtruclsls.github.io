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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        SimpleEntities db = new SimpleEntities();
        BN_Prod pt = new BN_Prod();
        void refreshDl()
        {
            list = db.Products.ToList();
            dgvProdORDER.DataSource = list;
        }
        List<Product> list = new List<Product>();
        private void dgvProdORDER_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdORDER.SelectedRows.Count <= 0) return;
            Product pt = (Product)dgvProdORDER.SelectedRows[0].DataBoundItem;
            txtIDProd.Text = pt.Id.ToString();
            txtNameProd.Text = pt.Name;
            txtPriceProd.Text = pt.Price.ToString();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshDl();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            refreshDl();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dgvOrder.AutoGenerateColumns = false;
       
        }

        private void txtSeachr_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtSeachr.Text))
            {
                dgvProdORDER.DataSource = list.ToList();
            }
            else
            {
                dgvProdORDER.DataSource = list.Where(pt => pt.Name.Contains(txtSeachr.Text) ||  pt.Id.ToString().Contains(txtSeachr.Text) || pt.Price.ToString().Contains(txtSeachr.Text)).ToList();
            }
            if (e.KeyChar == '\r')
            {
                txtQuantity.Focus();
                return;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAdd.PerformClick();
                return;
            }
            String hople = "123456789";
            if (hople.IndexOf(e.KeyChar) < 0)
            {
                btnAdd.Enabled = false;
                return;
            }
            foreach(char c in txtQuantity.Text)
                if(hople.IndexOf(c)< 0)
                {
                    btnAdd.Enabled = false;
                    return;
                }
            btnAdd.Enabled = true;
        }
        List<OrderProduct> L = new List<OrderProduct>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderProduct op = new OrderProduct() { Quantity = int.Parse(txtQuantity.Text), Price = int.Parse(txtQuantity.Text), ProductId = int.Parse(txtIDProd.Text) };
            L.Add(op);
            dgvOrder.DataSource = L.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              if (dgvOrder.DataSource != null)
               {
                   if (string.IsNullOrWhiteSpace(txtNameOrder.Text))
                   {
                       MessageBox.Show("Please enter name");
                       txtQuantity.Focus();
                   }
                   else { 
                   Order ord = new Order() { ordDate = DateTime.Now, ClientName = txtNameOrder.Text };
                   ord.OrderProducts = L;
                   db.Orders.Add(ord);
                   db.SaveChanges();

                   MessageBox.Show("Them order thanh cong!");

                       dgvOrder.DataSource = new List<OrderProduct>();
                       refreshDl();
                   }
               }
               else
               {
                   MessageBox.Show("Mời thêm dữ liệu ....");
               }
         //   dgvOrder.DataSource = db.Orders.ToList();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string kiemtra = txtQuantity.Text;
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                btnAdd.Enabled = false;
                return;
            }
            String hople = "123456789";
            foreach(Char c in kiemtra)
            {
                if (hople.IndexOf(c) >= 0) continue;
                else
                {
                    btnAdd.Enabled = false;
                }
            }
            btnAdd.Enabled = true;

        }
    }
}
