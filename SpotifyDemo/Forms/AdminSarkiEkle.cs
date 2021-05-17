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
        ContextClass context = new ContextClass();
        SarkiService service = new SarkiService();
        SarkiSanatcilarService sarkiSanatcilarService = new SarkiSanatcilarService();

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
            foreach (var item in context.Sanatcis)
            {
                checkedListBox1.Items.Add(item.SanatciAd);
            }
            

            var albums = context.Albums.ToList();
            foreach (var item in albums)
            {
                cmbxSarkiAlbum.Items.Add(item.AlbumAd);
            }

            var sanatcis = context.Sanatcis.ToList();

            cmbxSarkiTur.Items.Add("Pop");
            cmbxSarkiTur.Items.Add("Caz");
            cmbxSarkiTur.Items.Add("Klasik");

        }

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                Sarki sarki = new Sarki();

                sarki.SarkiAd = tbxSarkiAd.Text;
                sarki.AlbumID = context.Albums.Where(x => x.AlbumAd == cmbxSarkiAlbum.Text).Select(y => y.AlbumID).FirstOrDefault();
                sarki.SarkiDinlenmeSayisi = 0;
                sarki.SarkiSure = Convert.ToInt32(tbxSarkiSure.Text);
                sarki.SarkiTarih = dateTimePicker1.Value;
                sarki.SarkiTur = cmbxSarkiTur.Text;

                var sanatcilar = checkedListBox1.CheckedItems;

                try
                {
                    service.Add(sarki);
                }
                catch
                {

                    MessageBox.Show("Sarki Eklenemedi");
                }

                MessageBox.Show("Sarki Eklendi");

                var sarki_yeni = context.Sarkis.Where(x => x.SarkiAd == tbxSarkiAd.Text).FirstOrDefault();

                foreach (var item in sanatcilar)
                {
                    SarkiSanatcilar sarkiSanatcilar = new SarkiSanatcilar();

                    sarkiSanatcilar.SarkiID = sarki_yeni.SarkiID;
                    var sanatciAd = item.ToString();
                    var sanatci = context.Sanatcis.Where(x => x.SanatciAd == sanatciAd).FirstOrDefault();
                    sarkiSanatcilar.SanatciID = sanatci.SanatciID;

                    sarkiSanatcilarService.Add(sarkiSanatcilar);


                }
            }
            else
            {
                MessageBox.Show("En Az 1 Adet Sanatci Secmelisiniz.");
            }

        }
    }
}
