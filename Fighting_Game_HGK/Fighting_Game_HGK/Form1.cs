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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        private void T_Tick(object sender, EventArgs e)
        {
            if(pbPower1.Value < pbPower1.Maximum)
            {
                if (pbPower1.Value + 2 > pbPower1.Maximum)
                {
                    pbPower1.Value = pbPower1.Maximum;
                }
                else {
                    pbPower1.Value += 2;
                }
            }
            if (pbPower2.Value < pbPower2.Maximum)
            {
                if (pbPower2.Value + 2 > pbPower2.Maximum)
                {
                    pbPower2.Value = pbPower2.Maximum;
                }
                else
                {
                    pbPower2.Value += 2;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 100;
            t.Tick += T_Tick;
            t.Start();
         
        }
        List<Nguoichoi> list = new List<Nguoichoi>();
        private void pbPower1_Click(object sender, EventArgs e)
        {
            pBox1.Image = Image.FromFile(@"C:\Users\Admin\source\repos\Fighting_Game_HGK\Fighting_Game_HGK\Pbox1\giphy.gif");
            pBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (pbHP2.Value - pbPower1.Value <= pbHP2.Minimum)
            {
                pbHP2.Value = 0;
            }
            else { 
                pbHP2.Value -= pbPower1.Value;        
               // pbHP2.Value -= pbPower1.Value;        
                     if (pbPower1.Value > 70)
                     {
                        int sotru = int.Parse(Math.Floor((double)pbPower1.Value / 3).ToString());
                            if(pbPower2.Value - sotru < pbPower2.Minimum)
                            {
                              pbPower2.Value = 0;
                            }
                            else
                            {
                              pbPower2.Value -= sotru;
                            }
                     }
//
            }
            if (pbHP1.Value == 0 || pbHP2.Value == 0)
            {
                fm_Luu_Ten n = new fm_Luu_Ten();
                n.ShowDialog();
                Nguoichoi nc = new Nguoichoi() { TenNguoiChoi = n.TenNguoiChoi, ThoiGianChoi = DateTime.Now };
                list.Add(nc);
                System.IO.File.WriteAllText("ketqua.json", Newtonsoft.Json.JsonConvert.SerializeObject(list), Encoding.UTF8);
                pbHP2.Value = pbHP2.Maximum;
                pbHP1.Value = pbHP1.Maximum;
            }
            pbPower1.Value = 0;
        }

        private void pbPower2_Click(object sender, EventArgs e)
        {
            pBox2.Image = Image.FromFile(@"C:\Users\Admin\source\repos\Fighting_Game_HGK\Fighting_Game_HGK\Pbox1\giphy 2.gif");
            pBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            if (pbHP1.Value - pbPower2.Value <= pbHP1.Minimum)
            {
                pbHP1.Value = 0;
            }
            else { 
            pbHP1.Value -= pbPower2.Value;
            if(pbPower2.Value > 70)
            {
                int sotru = int.Parse(Math.Floor((double)pbPower2.Value / 3).ToString());

                if(pbPower1.Value - sotru < pbPower1.Minimum)
                {
                    pbPower2.Value = 0;
                }
                else
                {
                    pbPower1.Value -= sotru;
                }
            }
            }
            if (pbHP2.Value == 0 || pbHP1.Value == 0)
            {
                fm_Luu_Ten n = new fm_Luu_Ten();
                n.ShowDialog();
                Nguoichoi nc = new Nguoichoi() { TenNguoiChoi = n.TenNguoiChoi, ThoiGianChoi = DateTime.Now };
                list.Add(nc);
                System.IO.File.WriteAllText("ketqua.json", Newtonsoft.Json.JsonConvert.SerializeObject(list), Encoding.UTF8);
                pbHP1.Value = pbHP1.Maximum;
                pbHP2.Value = pbHP2.Maximum;
            }
            pbPower2.Value = 0;
        }

        private void pbHP1_Click(object sender, EventArgs e)
        {
            int socong = int.Parse(Math.Floor((double)pbPower1.Value * 40 /100 ).ToString());
            if(pbHP1.Value + socong > pbHP1.Maximum)
            {
                pbHP1.Value = pbHP1.Maximum;
            }
            else
            {
                pbHP1.Value += socong;
            }
            pbPower1.Value = 0;

        }

        private void pbHP2_Click(object sender, EventArgs e)
        {
            int socong = int.Parse(Math.Floor((double)pbPower2.Value * 40 / 100).ToString());
            if(pbHP2.Value + socong > pbHP2.Maximum)
            {
                pbHP2.Value = pbHP2.Maximum;
            }
            else
            {
                pbHP2.Value += socong;
            }
            pbPower2.Value = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) pbPower1_Click(null,null);
            if (e.KeyCode == Keys.Space) pbPower2_Click(null, null);
        }
        List<Nguoichoi> lists = new List<Nguoichoi>();
        private void ngườiChiếnThắngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lists = new List<Nguoichoi>();
            string jsonData = System.IO.File.ReadAllText("ketqua.json", Encoding.UTF8);
            List<Nguoichoi> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Nguoichoi>>(jsonData);
            foreach (Nguoichoi nc in list) {
                lists.Add(nc);
            }
            fmKetQua kq = new fmKetQua();
            kq.DsKetqua = lists.ToList();
            kq.ShowDialog();
        }
    }
}
