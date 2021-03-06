using SpotifyDemo.Context;
using SpotifyDemo.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyDemo.Forms
{
    public partial class AdminAnasayfa : Form
    {
        ContextClass context = new ContextClass();
        SarkiService sarkiService = new SarkiService();
        SanatciService sanatciService = new SanatciService();
        AlbumService albumService = new AlbumService();

        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnSarkilar_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = context.Sarkis.ToList();
        }

        private void btnSanatcilar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Sanatcis.ToList();

        }

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Albums.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
            AdminSarkiEkle adminSarkiEkle = new AdminSarkiEkle();
            this.Hide();
            adminSarkiEkle.ShowDialog();
            this.Close();
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            AdminSanatciEkle adminSanatciEkle = new AdminSanatciEkle();
            this.Hide();
            adminSanatciEkle.ShowDialog();
            this.Close();
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            AdminAlbumEkle adminAlbumEkle = new AdminAlbumEkle();
            this.Hide();
            adminAlbumEkle.ShowDialog();
            this.Close();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            id = Convert.ToInt32(id);

            string dosya = "C:\\Users\\Charon\\Desktop\\SpotifyDemo\\SpotifyDemo\\TextFile\\Log.txt";


            StreamWriter sw = new StreamWriter(dosya);
            sw.WriteLine(id);
            sw.Close();
            Console.WriteLine(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                sarkiService.Delete(id);
            }
            catch
            {
                MessageBox.Show("Sarki silinirken bir sorunla karsilasildi.");
            }
            

        } //Sarki Sil.

        private void btnSanatciSil_Click(object sender, EventArgs e)
        {
            

            try
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                sanatciService.Delete(id);
            }
            catch
            {
                MessageBox.Show("Sanatci silinirken bir sorunla karsilasildi.");
            }

        }

        private void btnAlbumSil_Click(object sender, EventArgs e)
        {
            

            try
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                albumService.Delete(id);
            }
            catch
            {
                MessageBox.Show("Album silinirken bir sorunla karsilasildi.");
            }



        }

        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

        }


        private void btnSanatciGuncelle_Click(object sender, EventArgs e)
        {
            AdminSanatciGuncelle adminSanatciGuncelle = new AdminSanatciGuncelle();
            this.Hide();
            adminSanatciGuncelle.ShowDialog();
            this.Close();
        }

        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            AdminAlbumGuncelle adminalbumGuncelle = new AdminAlbumGuncelle();
            this.Hide();
            adminalbumGuncelle.ShowDialog();
            this.Close();
        }

        private void btnSarkiGuncelle_Click(object sender, EventArgs e)
        {
            AdminSarkiGuncelleme adminSarkiGuncelleme = new AdminSarkiGuncelleme();
            this.Hide();
            adminSarkiGuncelleme.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
