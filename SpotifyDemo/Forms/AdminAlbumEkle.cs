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

        Ping p = new Ping();
        ContextClass context = new ContextClass();
        AlbumService albumService = new AlbumService();
        SanatciService sanatciService = new SanatciService();

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

        private void lblPing_Click(object sender, EventArgs e)
        {
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());
        }

        private void lblPingYazi_Click(object sender, EventArgs e)
        {
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.AlbumAd = tbxAlbumAd.Text;

            var sanatciId = context.Sanatcis.Where(x => x.SanatciAd == cmbbxAlbumSanatci.SelectedItem.ToString()).Select(y => y.SanatciID).FirstOrDefault();

            Console.WriteLine(sanatciId);

            album.AlbumSanatciID = sanatciId;

            try
            {
                albumService.Add(album);
            }
            catch
            {
                MessageBox.Show("Album Eklenemedi");
            }
            MessageBox.Show("Album Eklendi");
        }

        private void AdminAlbumEkle_Load(object sender, EventArgs e)
        {
            var sanatcilar = context.Sanatcis;

            foreach (var s in sanatcilar)
            {
                cmbbxAlbumSanatci.Items.Add(s.SanatciAd);
            }
        }
    }
}
