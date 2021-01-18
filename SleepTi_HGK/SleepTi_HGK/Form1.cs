using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepTi_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.SelectedIndex = 0;
        }

        private void btnCalCulate_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex==0 && comboBox2.SelectedIndex ==0)
            {   
                textBox1.Text = "4:00 PM or 5:30 PM or 7:00 PM or 8:30 PM or 10:00 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:05 PM or 5:35 PM or 7:05 PM or 8:35 PM or 10:05 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:10 PM or 5:40 PM or 7:10 PM or 8:40 PM or 10:10 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:15 PM or 5:45 PM or 7:15 PM or 8:45 PM or 10:15 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:20 PM or 5:50 PM or 7:20 PM or 8:50 PMor 10:20 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:25 PM or 5:55 PM or 7:25 PM or 8:55 PMor 10:25 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:30 PM or 6:00 PM or 7:30 PM or 9:00 PMor 10:30 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 7 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:35 PM or 6:05 PM or 7:35 PM or 9:05 PMor 10:35 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 8 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:40 PM or 6:10 PM or 7:40 PM or 9:10 PMor 10:40 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 9 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:45 PM or 6:15 PM or 7:45 PM or 9:15 PMor 10:45 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 10 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:50 PM or 6:20 PM or 7:50 PM or 9:20 PMor 10:50 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 11 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "4:55 PM or 6:25 PM or 7:55 PM or 9:25 PMor 10:55 PM";
            }
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 12 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:00 PM or 6:30 PM or 8:00 PM or 9:30 PMor 11:00 PM";
            }
            //2h
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:00 PM or 6:30 PM or 8:00 PM or 9:30 PM or 11:00 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:05 PM or 6:35 PM or 8:05 PM or 9:35 PM or 11:05 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:10 PM or 6:40 PM or 8:10 PM or 9:40 PM or 11:10 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:15 PM or 6:45 PM or 8:15 PM or 9:45 PM or 11:15 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:20 PM or 6:50 PM or 8:20 PM or 9:50 PMor 11:20 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:25 PM or 6:55 PM or 8:25 PM or 9:55 PMor 11:25 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:30 PM or 7:00 PM or 8:30 PM or 10:00 PMor 11:30 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 7 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:35 PM or 6:05 PM or 7:35 PM or 9:05 PMor 11:35 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 8 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:40 PM or 7:10 PM or 8:40 PM or 9:10 PMor 11:40 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 9 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:45 PM or 7:15 PM or 8:45 PM or 10:15 PMor 11:45 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 10 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:50 PM or 7:20 PM or 8:50 PM or 10:20 PMor 11:50 PM";
            }
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 11 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "5:55 PM or 7:25 PM or 8:55 PM or 10:25 PMor 11:55 PM";
            }
            
            //3h
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:00 PM or 7:30 PM or 9:00 PM or 10:30 PM or 12:00 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:05 PM or 7:35 PM or 9:05 PM or 10:35 PM or 12:05 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:10 PM or 7:40 PM or 9:10 PM or 10:40 PM or 12:10 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:15 PM or 7:45 PM or 9:15 PM or 10:45 PM or 12:15 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:20 PM or 7:50 PM or 9:20 PM or 10:50 PMor 12:20 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:25 PM or 7:55 PM or 9:25 PM or 10:55 PMor 12:25 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:30 PM or 8:00 PM or 9:30 PM or 11:00 PMor 12:30 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 7 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:35 PM or 8:05 PM or 9:35 PM or 11:05 PMor 12:35 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 8 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:40 PM or 8:10 PM or 9:40 PM or 11:10 PMor 12:40 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 9 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "645 PM or 8:15 PM or 9:45 PM or 11:15 PMor 12:45 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 10 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:50 PM or 8:20 PM or 9:50 PM or 11:20 PMor 12:50 AM";
            }
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 11 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "6:55 PM or 8:25 PM or 9:55 PM or 11:25 PMor 12:55 AM";
            }
            //4h
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:00 PM or 8:30 PM or 10:00 PM or 11:30 PM or 1:00 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:05 PM or 8:35 PM or 10:05 PM or 11:35 PM or 1:05 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:10 PM or 8:40 PM or 10:10 PM or 11:40 PM or 1:10 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:15 PM or 8:45 PM or 10:15 PM or 11:45 PM or 1:15 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:20 PM or 8:50 PM or 10:20 PM or 11:50 PM or 1:20 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:25 PM or 8:55 PM or 10:25 PM or 11:55 PM or 1:25 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:30 PM or 9:00 PM or 10:30 PM or 12:00 AM or 1:30 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 7 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:35 PM or 9:05 PM or 10:35 PM or 12:05 AM or 1:35 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 8 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:40 PM or 9:10 PM or 10:40 PM or 12:10 AM or 1:40 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 9 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:45 PM or 9:15 PM or 10:45 PM or 12:15 AM or 1:45 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 10 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:50 PM or 9:20 PM or 10:50 PM or 12:20 AM or 1:50 AM";
            }
            if (comboBox1.SelectedIndex == 3 && comboBox3.SelectedIndex == 11 && comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "7:55 PM or 9:25 PM or 10:55 PM or 12:25 AM or 1:55 AM";
            }


            /**  switch (choose)
              {case 1;
                      break;
               case 2;
                      break;
               case 3;
                      break;
               case 4;
                      break;

              }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
