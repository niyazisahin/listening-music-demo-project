using SpotifyDemo.Context;
using SpotifyDemo.Models;
using SpotifyDemo.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyDemo.Forms
{
    public partial class AdminSanatciGuncelle : Form
    {
        AdminAnasayfa adminAnasayfa = new AdminAnasayfa();

        ContextClass context = new ContextClass();
        SarkiService sarkiService = new SarkiService();
        SanatciService sanatciService = new SanatciService();
        AlbumService albumService = new AlbumService();
        
        string dosya = "C:\\Users\\Charon\\Desktop\\SpotifyDemo\\SpotifyDemo\\TextFile\\Log.txt";
        

        public AdminSanatciGuncelle()
        {
            InitializeComponent();
        }

        private void btnAdminAnasayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }

        private void btnSanatciGuncelle_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            Sanatci sanatci = new Sanatci();
            sanatci.SanatciAd = tbxSanatciAd.Text;
            sanatci.SanatciUlke = tbxSanatciUlke.Text;
            try
            {
                sanatciService.Update(id, sanatci);
            }
            catch
            {
                MessageBox.Show("Sanatci Guncellenemedi.");
            }

            MessageBox.Show("Sanatci Guncellendi.");
            
        }

        private void AdminSanatciGuncelle_Load(object sender, EventArgs e)
        {

            try
            {
            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            var sanatci = sanatciService.GetByID(id);
            tbxSanatciAd.Text = sanatci.SanatciAd;
            tbxSanatciUlke.Text = sanatci.SanatciUlke;
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sanatci Secmelisiniz");
                AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                this.Hide();
                adminAnasayfa.ShowDialog();
                this.Close();
            }

        }


    }
}
