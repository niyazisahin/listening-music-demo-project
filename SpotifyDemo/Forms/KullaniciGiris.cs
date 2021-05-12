using SpotifyDemo.Context;
using SpotifyDemo.Forms;
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
//using SpotifyDemo.Context;

namespace SpotifyDemo
{
    public partial class KullaniciGiris : Form
    {
        ContextClass context = new ContextClass();
        Ping p = new Ping();
        public KullaniciGiris()
        {

            InitializeComponent();
        }


        private void KullaniciGrisi_Load(object sender, EventArgs e)
        {
            var tarih = DateTime.Now;
            lblTarih.Text = tarih.ToString();

            
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());
        }

        private void btnKullanici_Click_1(object sender, EventArgs e)
        {
            string mail = tbxKullaniciAd.Text;
            string sifre = tbxKullaniciSifre.Text;

            Console.WriteLine("Giris Tusuna Basildi");

            Console.WriteLine(mail);
            Console.WriteLine(sifre);

            foreach (var item in context.Kullanicis)
            {
                if (item.KullaniciAd == mail)
                {
                    if (item.KullaniciSifre == sifre)
                    {
                        Console.WriteLine("Kullanici Giris Basarili");
                        KullaniciForm kullaniciForm = new KullaniciForm();
                        this.Hide();
                        kullaniciForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblPing_Click(object sender, EventArgs e)
        {
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());
        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            GirisEkran girisEkran = new GirisEkran();
            this.Hide();
            girisEkran.ShowDialog();
            this.Close();
        }
    }
}
