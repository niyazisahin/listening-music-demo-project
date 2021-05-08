using SpotifyDemo.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SpotifyDemo.Context;

namespace SpotifyDemo
{
    public partial class KullaniciGrisi : Form
    {
        ContextClass context = new ContextClass();
        public KullaniciGrisi()
        {

            InitializeComponent();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
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

        private void KullaniciGrisi_Load(object sender, EventArgs e)
        {

        }
    }
}
