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

                var sarkilar = context.SarkiSanatcilars.Where(x => x.SarkiID == id).ToList();

                SarkiSanatcilarService sarkiSanatcilarService = new SarkiSanatcilarService();

                foreach (var item in sarkilar)
                {
                    sarkiSanatcilarService.Delete(item.SarkiSanatcilarID);
                }

                var sanatcilar = checkedListBox1.CheckedItems;

                List<int> sanatcilarIdListe = new List<int>();

                foreach (var item in sanatcilar)
                {
                    var sanatcilarAd = context.Sanatcis.Where(x => x.SanatciAd == item.ToString()).FirstOrDefault();
                    sanatcilarIdListe.Add(sanatcilarAd.SanatciID);
                }

                foreach (var item in sanatcilarIdListe)
                {
                    SarkiSanatcilar sarkiSanatcilar = new SarkiSanatcilar();

                    sarkiSanatcilar.SarkiID = id;
                    sarkiSanatcilar.SanatciID = item;

                    sarkiSanatcilarService.Add(sarkiSanatcilar);
                }

            }
            catch
            {
                MessageBox.Show("Sarki Guncellenemedi.");
            }

            MessageBox.Show("Sarki Guncellendi.");
        }

        private void AdminSarkiGuncelleme_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(dosya);
                int id = Convert.ToInt32(sr.ReadLine());
                sr.Close();

                var sanatciListe = context.Sanatcis.ToList();
                var sanatcilarId = context.SarkiSanatcilars.Where(x => x.SarkiID == id).Select(y => y.SanatciID).ToList();

                foreach (var item in sanatciListe)
                {
                    checkedListBox1.Items.Add(item.SanatciAd);
                }

                List<string> sanatcilarAd = new List<string>();
                foreach (var item in sanatcilarId)
                {
                    var sanatci = context.Sanatcis.Where(x => x.SanatciID == item).FirstOrDefault();
                    var sanatciAd = sanatci.SanatciAd;

                    sanatcilarAd.Add(sanatciAd);

                }

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (sanatcilarAd.Contains(checkedListBox1.Items[i].ToString()))
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }



                foreach (var item in context.Albums)
                {
                    cmbxAlbumSanatci.Items.Add(item.AlbumAd);
                }
                cmbxTur.Items.Add("Pop");
                cmbxTur.Items.Add("Caz");
                cmbxTur.Items.Add("Klasik");

                var sarki = sarkiService.GetByID(id);
                tbxSarkiAd.Text = sarki.SarkiAd;
                tbxDinlenmeSayisi.Text = sarki.SarkiDinlenmeSayisi.ToString();
                tbxSure.Text = sarki.SarkiSure.ToString();
                cmbxTur.SelectedItem = sarki.SarkiTur;
                cmbxAlbumSanatci.SelectedItem = context.Albums.Where(x => x.AlbumID == sarki.AlbumID).Select(y => y.AlbumAd).FirstOrDefault();
                dateTimePicker1.Value = sarki.SarkiTarih;
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sarki Seciniz.");
                AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                this.Hide();
                adminAnasayfa.ShowDialog();
                this.Close();
            }
            
        }

        private void btnAdminAnasayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }
    }
}
