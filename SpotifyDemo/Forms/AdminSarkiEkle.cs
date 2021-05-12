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
    public partial class AdminSarkiEkle : Form
    {
        Ping p = new Ping();
        ContextClass context = new ContextClass();
        SarkiService service = new SarkiService();

        public AdminSarkiEkle()
        {
            InitializeComponent();
        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }

        private void AdminSarkiEkle_Load(object sender, EventArgs e)
        {
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());

            var albums = context.Albums.ToList();
            foreach (var item in albums)
            {
                cmbxSarkiAlbum.Items.Add(item.AlbumAd);
            }

            var sanatcis = context.Sanatcis.ToList();
            foreach (var item in sanatcis)
            {
                cmbxSarkiSanatci.Items.Add(item.SanatciAd);
            }

            cmbxSarkiTur.Items.Add("Pop");
            cmbxSarkiTur.Items.Add("Caz");
            cmbxSarkiTur.Items.Add("Rock");

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

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
            Sarki sarki = new Sarki();
            sarki.SarkiAd = tbxSarkiAd.Text;
            sarki.AlbumID = context.Albums.Where(x => x.AlbumAd == cmbxSarkiAlbum.Text).Select(y => y.AlbumID).FirstOrDefault();
            sarki.SarkiDinlenmeSayisi = 0;
            sarki.SarkiSure = Convert.ToInt32(tbxSarkiSure.Text);
            sarki.SarkiTarih = dateTimePicker1.Value;
            sarki.SarkiTur = cmbxSarkiTur.Text;

            try
            {
                service.Add(sarki);
            }
            catch
            {

                MessageBox.Show("Sarki Eklenemedi");
            }

            MessageBox.Show("Sarki Eklendi");

        }
    }
}
