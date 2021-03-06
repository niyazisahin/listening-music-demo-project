using SpotifyDemo.Context;
using SpotifyDemo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyDemo
{
    public partial class GirisEkran : Form
    {
        ContextClass context = new ContextClass();
        public GirisEkran()
        {
            InitializeComponent();
        }

        private void GirisEkran_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            this.Hide();
            adminGiris.ShowDialog();
            this.Close();

        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            this.Hide();
            kullaniciGiris.ShowDialog();
            this.Close();

        }

        private void pictureKullanici_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            this.Hide();
            kullaniciGiris.ShowDialog();
            this.Close();
        }

        private void pictureAdmin_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            this.Hide();
            adminGiris.ShowDialog();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
