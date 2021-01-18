using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMonitor_By_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            t.Interval = 15000;
            t.Tick += T_Tick;

        }
        //đạo đối tượng Timer 

        Timer t = new Timer();
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if(btnMonitor.Text == "Start Monitor")
            { 
                
                ChayLenh();
                t.Start();
                //KHi người dùng ấn click vào Stop Monitor thì dừng lại 
                btnMonitor.Text = "Stop Monitor";
            }
            else
            {
                t.Stop();
                btnMonitor.Text = "Start Monitor";
                lblstatus.Text = "Stopped";
            }
        }
        private void T_Tick(object sender, EventArgs e)
        {
            ChayLenh();
        }
        async Task ChayLenh()
        {
            Task.Run(() => { 
            lblstatus.Text = "Running......";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C echo START >> D:\\tasklist.txt & echo %date% %time% >> D:\\tasklist.txt & tasklist /v >> D:\\tasklist.txt & echo END >> D:\\tasklist.txt";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            lblstatus.Text = "Done";
            
            });
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.DefaultExt = ".txt";
            ofd.InitialDirectory = "D:\\";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                IEnumerable<string> lines = System.IO.File.ReadLines(fileName);
                List<Proc> list = new List<Proc>();
                int linenumber = 0;
                int[] columnLength = null;
                DateTime thoigianchay = new DateTime();
                foreach (string line in lines)
                {
                    if (line.Trim() == "START")
                    {
                        linenumber = 0;
                        continue;
                    }
                    if (++linenumber == 1)
                    {
                        string l = line.Trim().Substring(4);
                        l = l.Substring(0, l.IndexOf("."));
                        thoigianchay = DateTime.ParseExact(l, "MM/dd/yyyy HH:mm:ss", null);
                        continue;
                    }
                    if (linenumber == 2 || linenumber == 3) continue;
                    if (linenumber == 4)
                    {
                        string[] columns = line.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        columnLength = new int[columns.Length];
                        for (int i = 0; i < columns.Length; i++)
                            columnLength[i] = columns[i].Length;
                        continue;
                    }
                    if (line.Trim() != "END" && line.Trim() != "")
                    {
                        Proc p = new Proc();
                        p.ThoiGianChay = thoigianchay;
                        int vitribatdau = 0;
                        p.TenProc = line.Substring(0, columnLength[0]).Trim();
                        vitribatdau = columnLength[0] + 1;
                        string linevalue = line.Substring(vitribatdau, columnLength[1]).Trim();
                        p.PID = int.Parse(linevalue);
                        vitribatdau = vitribatdau + columnLength[1] + 1;
                        p.SessionName = line.Substring(vitribatdau, columnLength[2]).Trim();
                        vitribatdau = vitribatdau + columnLength[2] + 1;

                        p.SesssionNo = int.Parse(line.Substring(vitribatdau, columnLength[3]).Trim());
                        vitribatdau = vitribatdau + columnLength[3] + 1;

                        p.MemUsage = int.Parse(line.Substring(vitribatdau, columnLength[4]).Replace(" K", "").Replace(",", "").Trim());
                        vitribatdau = vitribatdau + columnLength[4] + 1;

                        p.Status = line.Substring(vitribatdau, columnLength[5]).Trim();
                        vitribatdau = vitribatdau + columnLength[5] + 1;


                        p.Username = line.Substring(vitribatdau, columnLength[6]).Trim();
                        vitribatdau = vitribatdau + columnLength[6] + 1;

                        p.CPUTime = line.Substring(vitribatdau, columnLength[7]).Trim();
                        vitribatdau = vitribatdau + columnLength[7] + 1;


                        p.WindowTitle = line.Substring(vitribatdau, columnLength[8]).Trim();
                        vitribatdau = vitribatdau + columnLength[8] + 1;

                        list.Add(p);
                    }
                }
                dgvProcessMonitor.DataSource = list;
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".json";
            sfd.FileName = "process.json";
            sfd.InitialDirectory = "D:\\";
            sfd.ShowDialog();
            String filename = sfd.FileName;
            System.IO.File.WriteAllText(filename, Newtonsoft.Json.JsonConvert.SerializeObject((List<Proc>)dgvProcessMonitor.DataSource),Encoding.UTF8);
            MessageBox.Show("Finished");
        }
    }
}
