using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Trac_Nghiem.BN;
namespace Game_Trac_Nghiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Question_Bn cm = new Question_Bn();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvQuestion.DataSource = cm.laytatcacauhoi();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbFalse.Checked == true)
                {
                    if (cm.ThemDulieu(txtQuestion.Text, int.Parse(txtScores.Text), false))
                    {
                        MessageBox.Show("Them moi  thanh cong! ");
                    }
                    return;
                }

                if (cbTrue.Checked == true)
                {
                    if (cm.ThemDulieu(txtQuestion.Text, int.Parse(txtScores.Text), true))
                    {
                        MessageBox.Show("Them moi thanh cong! ");
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Loi khi them mới...");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi roi" +ex.Message);
            }
        }
    }
}
