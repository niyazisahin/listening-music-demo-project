using SpotifyDemo.Context;
using SpotifyDemo.Models;
using SpotifyDemo.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyDemo.Forms
{
    public partial class AdminAlbumEkle : Form
    {

        ContextClass context = new ContextClass();
        AlbumService albumService = new AlbumService();
        SanatciService sanatciService = new SanatciService();
        AlbumSanatciListeService albumSanatciListeService = new AlbumSanatciListeService();

        public AdminAlbumEkle()
        {
            InitializeComponent();
        }

        private void btnAdminAnasayfaDon_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                    Album album = new Album();
                    album.AlbumAd = tbxAlbumAd.Text;


                    try
                    {
                        albumService.Add(album);
                    }
                    catch
                    {
                        MessageBox.Show("Album Eklenemedi");
                    }
                    MessageBox.Show("Album Eklendi");

                var albumBul = context.Albums.Where(x => x.AlbumAd == tbxAlbumAd.Text).FirstOrDefault();
                var albumId = albumBul.AlbumID;

                var sanatcilar = checkedListBox1.CheckedItems;
                foreach (var item in sanatcilar)
                {
                    AlbumSanatciListe albumSanatciListe = new AlbumSanatciListe();
                    var sanatci = context.Sanatcis.Where(x => x.SanatciAd == item.ToString()).FirstOrDefault();
                    var sanatciId = sanatci.SanatciID;

                    albumSanatciListe.AlbumID = albumId;
                    albumSanatciListe.SanatciID = sanatciId;

                    albumSanatciListeService.Add(albumSanatciListe);
                }
            }
            else
            {
                MessageBox.Show("En Az 1 Sanatci Secmelisiniz.");
            }

               
        }

        private void AdminAlbumEkle_Load(object sender, EventArgs e)
        {
            var sanatcilar = context.Sanatcis;

            foreach (var item in sanatcilar)
            {
                checkedListBox1.Items.Add(item.SanatciAd);
            }
        }
    }
}
