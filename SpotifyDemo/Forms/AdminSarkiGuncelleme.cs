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
    public partial class AdminSarkiGuncelleme : Form
    {

        AdminAnasayfa adminAnasayfa = new AdminAnasayfa();

        ContextClass context = new ContextClass();
        SarkiService sarkiService = new SarkiService();

        string dosya = "C:\\Users\\Charon\\Desktop\\SpotifyDemo\\SpotifyDemo\\TextFile\\Log.txt";
        public AdminSarkiGuncelleme()
        {
            InitializeComponent();
        }

        private void btnSarkiGuncelle_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            Sarki sarki = new Sarki();
            sarki.SarkiAd = tbxSarkiAd.Text;
            sarki.SarkiTarih = dateTimePicker1.Value;
            sarki.SarkiSure = Convert.ToInt32(tbxSure.Text);
            sarki.SarkiDinlenmeSayisi = Convert.ToInt32(tbxDinlenmeSayisi.Text);
            sarki.SarkiTur = cmbxTur.Text;
            sarki.AlbumID = context.Albums.Where(x => x.AlbumAd == cmbxAlbumSanatci.Text).Select(y => y.AlbumID).FirstOrDefault();
            try
            {
                sarkiService.Update(id, sarki);
            }
            catch
            {
                MessageBox.Show("Sarki Guncellenemedi.");
            }

            MessageBox.Show("Sarki Guncellendi.");
        }

        private void AdminSarkiGuncelleme_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(dosya);
            int id = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            foreach (var item in context.Albums)
            {
                cmbxAlbumSanatci.Items.Add(item.AlbumAd);
            }
            cmbxTur.Items.Add("Pop");
            cmbxTur.Items.Add("Caz");
            cmbxTur.Items.Add("Rock");

            var sarki = sarkiService.GetByID(id);
            tbxSarkiAd.Text = sarki.SarkiAd;
            tbxDinlenmeSayisi.Text = sarki.SarkiDinlenmeSayisi.ToString();
            tbxSure.Text = sarki.SarkiSure.ToString();
            cmbxTur.SelectedItem = sarki.SarkiTur;
            cmbxAlbumSanatci.SelectedItem = context.Albums.Where(x => x.AlbumID == sarki.AlbumID).Select(y => y.AlbumAd).FirstOrDefault();
            dateTimePicker1.Value = sarki.SarkiTarih;
            
        }

        private void btnAdminAnasayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }
    }
}
