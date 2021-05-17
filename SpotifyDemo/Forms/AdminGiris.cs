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

namespace SpotifyDemo
{
    public partial class AdminGiris : Form
    {
        ContextClass context = new ContextClass();
        
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string mail = tbxAdminAd.Text;
            string sifre = tbxAdminSifre.Text;
            bool sayac = false;

            foreach (var item in context.Admins)
            {
                if (item.AdminMail == mail)
                {
                    if (item.AdminSifre == sifre)
                    {
                        Console.WriteLine("Admin Giris Basarili");
                        AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                        this.Hide();
                        adminAnasayfa.ShowDialog();
                        this.Close();

                        sayac = true;
                    }

                }
            }
            if (!sayac)
            {
                MessageBox.Show("Girilen Bilgiler Hatalıdır!");
            }
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            var tarih = DateTime.Now;
            lblTarih.Text = tarih.ToString();
           

        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            GirisEkran girisEkran = new GirisEkran();
            this.Hide();
            girisEkran.ShowDialog();
            this.Close();
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
