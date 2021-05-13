using SpotifyDemo.Context;
using SpotifyDemo.Models;
using SpotifyDemo.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyDemo.Forms
{
    public partial class KullaniciKayit : Form
    {
        ContextClass context = new ContextClass();

        KullanıcıService kullaniciService = new KullanıcıService();
        CalmaListesiService calmaListesiService = new CalmaListesiService();

        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {


            Kullanici kullanici = new Kullanici();

            kullanici.KullaniciAd = tbxKullaniciAd.Text;
            kullanici.KullaniciMail = tbxKullaniciMail.Text;
            kullanici.KullaniciSifre = tbxKullaniciSifre.Text;
            kullanici.KullaniciAbonelikTur = cmbxxUyelikTur.Text;
            kullanici.KullaniciUlke = TbxKullaniciUlke.Text;

            try
            {
                kullaniciService.Add(kullanici);

                CalmaListesiOlustur(kullanici.KullaniciID, "Pop");
                CalmaListesiOlustur(kullanici.KullaniciID, "Caz");
                CalmaListesiOlustur(kullanici.KullaniciID, "Rock");

                MessageBox.Show("Kullanici Eklendi.");
            }
            catch 
            {

                MessageBox.Show("Kullanici Ekleme Başarısız!");
            }
            
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            this.Hide();
            kullaniciGiris.ShowDialog();
            this.Close();
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            cmbxxUyelikTur.Items.Add("Premium");
            cmbxxUyelikTur.Items.Add("Standart");
        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            GirisEkran girisEkran = new GirisEkran();
            this.Hide();
            girisEkran.ShowDialog();
            this.Close();
        }

        void CalmaListesiOlustur(int id, string listeAd)
        {
            CalmaListesi calmaListesi = new CalmaListesi();
            

            calmaListesi.KullaniciID = id;
            calmaListesi.ListeAd = listeAd;

            calmaListesiService.Add(calmaListesi);

        }
    }
}
