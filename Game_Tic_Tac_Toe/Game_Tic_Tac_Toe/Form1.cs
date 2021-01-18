using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<int> List1 = new List<int>();

        List<int> List2 = new List<int>();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text != "") return;
            btn.Text = txtCurrent.Text.Replace("Current: ", "");


            if(btn.Text == "O")
            {
                txtCurrent.Text = "Current: X";
                btn.ForeColor = Color.Red;

            }
            else
            {
                txtCurrent.Text = "Current: O";
                btn.ForeColor = Color.Blue;
            }   
            Kiemtra();

            /*
            Button btn = (Button)sender;
            string name = btn.Name;
            if(coutn % 2 == 0 )
            {
                btn.Text = "X";
                btn.BackColor = Color.Red;
                btn.Enabled = false;
                if (name.Equals("button1_1"))
                {
                    List1.Add(1);
                }
                if (name.Equals("button1_2"))
                {
                    List1.Add(2);
                }
                if (name.Equals("button1_3"))
                {
                    List1.Add(3);
                }
                if (name.Equals("button2_1"))
                {
                    List1.Add(4);
                }
                if (name.Equals("button2_2"))
                {
                    List1.Add(5);
                }
                if (name.Equals("button2_3"))
                {
                    List1.Add(6);
                }
                if (name.Equals("button3_1"))
                {
                    List1.Add(7);
                }
                if (name.Equals("button3_2"))
                {
                    List1.Add(8);
                }
                if (name.Equals("button3_3"))
                {
                    List1.Add(9);
                }
                check();
                if (check() == true)
                {
                    MessageBox.Show("Player 1 Win ");
                }
           

            }
            else
            {/*
                btn.Text = "O";
                btn.BackColor = Color.White;
                btn.Enabled = false;
                if (name.Equals("button1_1"))
                {
                    List2.Add(1);
                }
                if (name.Equals("button1_2"))
                {
                    List2.Add(2);
                }
                if (name.Equals("button1_3"))
                {
                    List2.Add(3);
                }
                if (name.Equals("button2_1"))
                {
                    List2.Add(4);
                }
                if (name.Equals("button2_2"))
                {
                    List2.Add(5);
                }
                if (name.Equals("button2_3"))
                {
                    List2.Add(6);
                }
                if (name.Equals("button3_1"))
                {
                    List2.Add(7);
                }
                if (name.Equals("button3_2"))
                {
                    List2.Add(8);
                }
                if (name.Equals("button3_3"))
                {
                    List2.Add(9);
                }
                check();
                if (check() == true)
                {
                    MessageBox.Show("Player 2 Win ");
                }

            }
            coutn++;*/
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void ClearFrom()
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                ((Button)c).Text = "";
            }
        }
        public void Kiemtra()
        {
            if(((button1_1.Text == button2_1.Text && button1_1.Text == button3_1.Text ) ||  (button1_1.Text == button1_2.Text && button1_1.Text == button1_3.Text) || (button1_1.Text == button2_2.Text && button1_1.Text == button3_3.Text)) && button1_1.Text != "") 
            {
                if(button1_1.Text == "O")
                {
                    txtPlay_1.Text = string.Format("Player 1 : {0}", int.Parse(txtPlay_1.Text.Replace("Player 1 : ", "")) + 1);
                    if (MessageBox.Show("Player 1 Win ! Continue to play?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearFrom();
                    }
                }
                else
                {
                    txtPlay_2.Text = string.Format("Player 2 : {0}", int.Parse(txtPlay_2.Text.Replace("Player 2 : ", "")) + 1);
                    if (MessageBox.Show("Player 2 Win ! Continue to play?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearFrom();
                    }
                }
            }
            if (((button2_2.Text == button1_3.Text && button2_2.Text == button3_1.Text) || (button2_2.Text == button1_2.Text && button2_2.Text == button3_2.Text) || (button2_2.Text == button2_1.Text && button2_2.Text == button2_3.Text)) && button2_2.Text != "")
            {
                if (button1_1.Text == "O")
                {
                    txtPlay_1.Text = string.Format("Player 1 : {0}", int.Parse(txtPlay_1.Text.Replace("Player 1 : ", "")) + 1);
                    if (MessageBox.Show("Player 1 Win ! Continue to play?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearFrom();
                    }
                }
                else
                {
                    txtPlay_2.Text = string.Format("Player 2 : {0}", int.Parse(txtPlay_2.Text.Replace("Player 2 : ", "")) + 1);
                    if (MessageBox.Show("Player 2 Win ! Continue to play?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearFrom();
                    }
                }
            }
            if (((button3_3.Text == button1_3.Text && button3_3.Text == button2_3.Text) || (button3_3.Text == button3_2.Text && button3_3.Text == button3_1.Text) ) && button3_3.Text != "")
            {
                if (button1_1.Text == "O")
                {
                    txtPlay_1.Text = string.Format("Player 1 : {0}", int.Parse(txtPlay_1.Text.Replace("Player 1 : ", "")) + 1);
                    if (MessageBox.Show("Player 1 Win ! Continue to play?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearFrom();
                    }
                }
                else
                {
                    txtPlay_2.Text = string.Format("Player 2 : {0}", int.Parse(txtPlay_2.Text.Replace("Player 2 : ", "")) + 1);
                    if (MessageBox.Show("Player 2 Win ! Continue to play?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearFrom();
                    }
                }
            }
        }
        public bool check()
        {
            if(List1.Contains(1) &&  List1.Contains(2) && List1.Contains(3))
            {
                return true;
            }
            if (List1.Contains(1) && List1.Contains(4) && List1.Contains(7))
            {
                return true;
            }
            if (List1.Contains(1) && List1.Contains(5) && List1.Contains(9))
            {
                return true;
            }
            if (List1.Contains(3) && List1.Contains(5) && List1.Contains(7))
            {
                return true;
            }
            if (List1.Contains(3) && List1.Contains(6) && List1.Contains(9))
            {
                return true;
            }
            if (List1.Contains(2) && List1.Contains(5) && List1.Contains(8))
            {
                return true;
            }
            if (List1.Contains(4) && List1.Contains(5) && List1.Contains(6))
            {
                return true;
            }
            if (List1.Contains(7) && List1.Contains(8) && List1.Contains(9))
            {
                return true;
            }
            //
            if (List2.Contains(1) && List2.Contains(2) && List2.Contains(3))
            {
                return true;
            }
            if (List2.Contains(1) && List2.Contains(4) && List2.Contains(7))
            {
                return true;
            }
            if (List2.Contains(1) && List2.Contains(5) && List2.Contains(9))
            {
                return true;
            }
            if (List2.Contains(3) && List2.Contains(5) && List2.Contains(7))
            {
                return true;
            }
            if (List2.Contains(3) && List2.Contains(6) && List2.Contains(9))
            {
                return true;
            }
            if (List2.Contains(2) && List2.Contains(5) && List2.Contains(8))
            {
                return true;
            }
            if (List2.Contains(4) && List2.Contains(5) && List2.Contains(6))
            {
                return true;
            }
            if (List2.Contains(7) && List2.Contains(8) && List2.Contains(9))
            {
                return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFrom();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Ketqua.txt", txtPlay_1.Text + " , " + txtPlay_2.Text + Environment.NewLine);
            txtPlay_1.Text = "";
            txtPlay_2.Text = "";
            MessageBox.Show("Saved success!");
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] DL = System.IO.File.ReadAllLines("Ketqua.txt");
            string ketqua = "";
            for (int i = DL.Length - 1; i >= (DL.Length >= 10 ? DL.Length - 10 : 0) ; i--){
                ketqua += DL[i] + "\n";
            }
            MessageBox.Show("TOP 10 : \n" + ketqua);
        }
    }
}
