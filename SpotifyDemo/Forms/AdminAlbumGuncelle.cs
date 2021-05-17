using SpotifyDemo.Context;
using SpotifyDemo.Models;
using SpotifyDemo.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyDemo.Forms
{
    public partial class AdminAlbumGuncelle : Form
    {
        AdminAnasayfa adminAnasayfa = new AdminAnasayfa();

        ContextClass context = new ContextClass();
        AlbumService albumService = new AlbumService();
        AlbumSanatciListeService albumSanatciListeService = new AlbumSanatciListeService();

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

            AlbumSanatciListeService albumSanatciListeService = new AlbumSanatciListeService(); 

            try
            {
                albumService.Update(id, album);
                var albumIdLer = context.AlbumSanatciListes.Where(x => x.AlbumID == id).ToList();
                foreach (var item in albumIdLer)
                {
                    albumSanatciListeService.Delete(item.AlbumSanatciListeID);
                }

                var sanatcilar = checkedListBox1.CheckedItems;
                
                List<int> sanatcilarIdListe = new List<int>();

                foreach (var item in sanatcilar)
                {
                    var sanatcilarAd = context.Sanatcis.Where(x => x.SanatciAd == item.ToString()).FirstOrDefault();
                    sanatcilarIdListe.Add(sanatcilarAd.SanatciID);
                }

                foreach (var item in sanatcilarIdListe)
                {
                    AlbumSanatciListe albumSanatciListe = new AlbumSanatciListe();

                    albumSanatciListe.AlbumID = id;
                    albumSanatciListe.SanatciID = item;

                    albumSanatciListeService.Add(albumSanatciListe);
                }

            }
            catch
            {
                MessageBox.Show("Album Guncellenemedi.");
            }

            MessageBox.Show("Album Guncellendi.");
        }

        private void AdminAlbumGuncelle_Load(object sender, EventArgs e)
        {
            var sanatciListe = context.Sanatcis.ToList();

            foreach (var item in sanatciListe)
            {
                checkedListBox1.Items.Add(item.SanatciAd);
            }

            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            try
            {
                var album = albumService.GetByID(id);
                var sanatcilar = context.AlbumSanatciListes.Where(x => x.AlbumID == id).Select(y => y.SanatciID).ToList();

                List<string> sanatcilarAd = new List<string>();
                foreach (var item in sanatcilar)
                {
                    var sanatci = context.Sanatcis.Where(x => x.SanatciID == item).FirstOrDefault();
                    var sanatciAd = sanatci.SanatciAd;

                    sanatcilarAd.Add(sanatciAd);
                    
                }

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (sanatcilarAd.Contains(checkedListBox1.Items[i].ToString()))
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }

                tbxAlbumAd.Text = album.AlbumAd;


            }
            catch (Exception )
            {
                MessageBox.Show("Bir Album Secmelisiniz!");
                AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                this.Hide();
                adminAnasayfa.ShowDialog();
                this.Close();
                
            }

            
            


        }
    }
}
