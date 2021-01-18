using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Search_API_HGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //http://www.omdbapi.com/?s=Avengers&apikey=73d91c83
            HttpClient client = new HttpClient();
            string jsonData =   client.GetStringAsync(string.Format("http://www.omdbapi.com/?s={0}&apikey=73d91c83",txtSearch.Text)).Result;
            TimPhim timPhim = Newtonsoft.Json.JsonConvert.DeserializeObject<TimPhim>(jsonData);
            lbltrangthaitim.Text = string.Format("Tìm thấy {0} phim với từ khóa {1}",timPhim.totalResults,txtSearch.Text);
            dgvMovieList.DataSource = timPhim.Search;
        }

        private void dgvMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMovieList.SelectedRows.Count > 0 ) {
                Search obj = (Search)dgvMovieList.SelectedRows[0].DataBoundItem;
                //http://www.omdbapi.com/?i=tt0491703&apikey=73d91c83
                HttpClient client = new HttpClient();
                String jsonData = client.GetStringAsync(string.Format("http://www.omdbapi.com/?i={0}&apikey=73d91c83", obj.imdbID)).Result;
                ThongTinPhim p = Newtonsoft.Json.JsonConvert.DeserializeObject<ThongTinPhim>(jsonData);

                txtTitle.Text = p.Title;
                txtReleased.Text = p.Released;
                txtRuntime.Text = p.Runtime;
                txtPlot.Text = p.Plot;
                txtLanguage.Text = p.Language;
                txtGenre.Text = p.Genre;
                txtDirector.Text = p.Director;
                txtActors.Text = p.Actors;

                pbPoster.ImageLocation = p.Poster;
                pbPoster.Load();

            }
        }
    }
}
