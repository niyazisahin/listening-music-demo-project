using SpotifyDemo.Context;
using SpotifyDemo.Models;
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
    public partial class AdminAlbumGuncelle : Form
    {
        AdminAnasayfa adminAnasayfa = new AdminAnasayfa();

        ContextClass context = new ContextClass();
        AlbumService albumService = new AlbumService();

        string dosya = "C:\\Users\\Charon\\Desktop\\SpotifyDemo\\SpotifyDemo\\TextFile\\Log.txt";
        public AdminAlbumGuncelle()
        {
            InitializeComponent();
        }

        private void btnAdminAnasayfaDon_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }

        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            Album album = new Album();
            album.AlbumAd = tbxAlbumAd.Text;
            album.AlbumSanatciID = context.Sanatcis.Where(x => x.SanatciAd == cmbbxAlbumSanatci.Text).Select(y => y.SanatciID).FirstOrDefault();
            Console.WriteLine(album.AlbumSanatciID);
            try
            {
                albumService.Update(id, album);
            }
            catch
            {
                MessageBox.Show("Album Guncellenemedi.");
            }

            MessageBox.Show("Album Guncellendi.");
        }

        private void AdminAlbumGuncelle_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            
            var album = albumService.GetByID(id);

            tbxAlbumAd.Text = album.AlbumAd;
            

            foreach (var item in context.Sanatcis)
            {
                cmbbxAlbumSanatci.Items.Add(item.SanatciAd);
                if (item.SanatciID == album.AlbumSanatciID)
                    cmbbxAlbumSanatci.SelectedItem = item.SanatciAd;

            }

        }
    }
}
