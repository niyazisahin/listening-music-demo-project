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
    public partial class KullaniciForm : Form
    {
        ContextClass context = new ContextClass();

        UlkeyeGoreDinlenmeService ulkeService = new UlkeyeGoreDinlenmeService();

        private int _id;

        public KullaniciForm(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            var ulkeler = context.Kullanicis.Select(x => x.KullaniciUlke).Distinct().ToList();

            foreach (var item in ulkeler)
            {
                cmbxUlkelereGore.Items.Add(item);
            }


            var kullanici = context.Kullanicis.Where(x => x.KullaniciID == _id).FirstOrDefault();
            //if (kullanici.KullaniciAbonelikTur == "Premium")
            //    btnDigerKullanicilar.Visible = false;

            var kullaniciAd = context.Kullanicis.Where(x => x.KullaniciID == this._id).Select(y => y.KullaniciAd).FirstOrDefault();
            lblKullaniciAd.Text = kullaniciAd;

            Console.WriteLine(_id);

            dataGridView1.DataSource = context.Sarkis.ToList();

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Sarkis.Where(x => x.SarkiTur == "Pop").ToList();
        }

        private void btnCaz_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Sarkis.Where(x => x.SarkiTur == "Caz").ToList();
        }

        private void btnKlasik_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Sarkis.Where(x => x.SarkiTur == "Klasik").ToList();
        }

        private void pctbxPop_Click(object sender, EventArgs e)
        {
            ListeYazdir("Pop");
        }

        private void pctxCaz_Click(object sender, EventArgs e)
        {
            ListeYazdir("Caz");
        }

        private void pctbxKlasik_Click(object sender, EventArgs e)
        {
            ListeYazdir("Klasik");
        }

        void ListeYazdir(string tur)
        {
            var calmaListesi = context.CalmaListesis.Where(x => x.KullaniciID == _id && x.ListeAd == tur).FirstOrDefault();
            var calmaListesiId = calmaListesi.CalmaListesiID;
            Console.Write(calmaListesiId);
            List<Sarki> sarkiListesi = new List<Sarki>();

            var sarkiIdListe = context.CalmaListesiSarkilars.Where(x => x.CalmaListesiID == calmaListesiId).ToList();
            Console.WriteLine(sarkiIdListe.Count);

            foreach (var item in sarkiIdListe)
            {
                Console.WriteLine(item.SarkiID);
                Console.WriteLine(item.CalmaListesiID);
                sarkiListesi.Add(context.Sarkis.Where(x => x.SarkiID == item.SarkiID).FirstOrDefault());
            }
            dataGridView1.DataSource = sarkiListesi;
        }

        private void btnListeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sarkiId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var sarkiTur = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    var calmaListesi = context.CalmaListesis.Where(x => x.ListeAd == sarkiTur && x.KullaniciID == _id).FirstOrDefault();
                    var calmaListesiId = calmaListesi.CalmaListesiID;

                    CalmaListeSarkilar calmaListesiSarkilar = new CalmaListeSarkilar();
                    calmaListesiSarkilar.CalmaListesiID = Convert.ToInt32(calmaListesiId);
                    calmaListesiSarkilar.SarkiID = sarkiId;

                    var sarkiVarMi = context.CalmaListesiSarkilars.Where(x => x.SarkiID == sarkiId && x.CalmaListesiID == calmaListesiId).FirstOrDefault();

                    CalmaListesiSarkilarService calmaListesiSarkilarService = new CalmaListesiSarkilarService();
                    if (sarkiVarMi != null)
                    {
                        MessageBox.Show("Bu Şarkı Listenizde Mevcut.");
                    }
                    else
                    {
                        calmaListesiSarkilarService.Add(calmaListesiSarkilar);

                    }

            }
            catch (Exception)
            {

                 MessageBox.Show("Bir Sarki Seciniz");
            }
                
        }

        private void btnTumSarkilar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Sarkis.ToList();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            List<Sarki> top10Liste = new List<Sarki>();
            top10Liste = context.Sarkis.OrderByDescending(x => x.SarkiDinlenmeSayisi).ToList();

            if (top10Liste.Count > 10)
            {
                top10Liste = top10Liste.GetRange(0, 10);
            }
            else
            {
                top10Liste = top10Liste.GetRange(0, top10Liste.Count);
            }
            
            dataGridView1.DataSource = top10Liste;
        }

        private void btnPop10_Click(object sender, EventArgs e)
        {
            Top10ListeGetir("Pop");
        }

        private void btnCaz10_Click(object sender, EventArgs e)
        {
            Top10ListeGetir("Caz");
        }

        private void btnKlasik10_Click(object sender, EventArgs e)
        {
            Top10ListeGetir("Klasik");
        }

        void Top10ListeGetir(string tur)
        {
            List<Sarki> top10Liste = new List<Sarki>();
            top10Liste = context.Sarkis.Where(x => x.SarkiTur == tur).OrderByDescending(y => y.SarkiDinlenmeSayisi).ToList();
            var index = 0;

            if (top10Liste.Count > 10)
            {
                index = 10;
            }
            else
            {
                index = top10Liste.Count;
            }

            top10Liste = top10Liste.GetRange(0, index);

            dataGridView1.DataSource = top10Liste;
        }

        private void cmbxUlkelereGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ulke = cmbxUlkelereGore.Text;
            var top10Liste = context.UlkeyeGoreDinlenmeSayisis.Where(x => x.UlkeAd == ulke).OrderByDescending(y => y.DinlenmeSayisi).ToList();

            
            var index = 0;

            if (top10Liste.Count > 10)
            {
                index = 10;
            }
            else
            {
                index = top10Liste.Count;
            }

            top10Liste = top10Liste.GetRange(0, index);

            List<Sarki> yeni_liste = new List<Sarki>();

            foreach(var item in top10Liste)
            {
                var yeni_sarki = context.Sarkis.Where(x => x.SarkiID == item.SarkiID).FirstOrDefault();
                yeni_liste.Add(yeni_sarki);

            }

            dataGridView1.DataSource = yeni_liste;
        }

        private void btnDigerKullanicilar_Click(object sender, EventArgs e)
        {
            DigerKullaniciForm digerKullaniciForm = new DigerKullaniciForm(_id);
            this.Hide();
            digerKullaniciForm.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UlkeyeGoreDinlenmeSayisi ulkeyeGoreDinlenmeSayisi = new UlkeyeGoreDinlenmeSayisi();

            var sarkiId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var ulke = context.Kullanicis.Where(x => x.KullaniciID == _id).Select(y => y.KullaniciUlke).FirstOrDefault();

            var sarki = context.Sarkis.Where(x => x.SarkiID == sarkiId).FirstOrDefault();

            sarki.SarkiDinlenmeSayisi++;

            var ulkeVarMi = context.UlkeyeGoreDinlenmeSayisis.Where(x => x.UlkeAd == ulke).FirstOrDefault(); 
            var sarkiVarMi = context.UlkeyeGoreDinlenmeSayisis.Where(x => x.SarkiID == sarkiId).FirstOrDefault();

            if (ulkeVarMi != null && sarkiVarMi != null)
            {
                var entity = context.UlkeyeGoreDinlenmeSayisis.Where(x => x.SarkiID == sarkiId).FirstOrDefault();

                entity.DinlenmeSayisi++;
                ulkeyeGoreDinlenmeSayisi.DinlenmeSayisi++;
                context.SaveChanges();
            }
            else
            {
                ulkeyeGoreDinlenmeSayisi.SarkiID = sarkiId;
                ulkeyeGoreDinlenmeSayisi.UlkeAd = ulke;
                ulkeyeGoreDinlenmeSayisi.DinlenmeSayisi = 1;

                ulkeService.Add(ulkeyeGoreDinlenmeSayisi);
            }



        }

        private void btnListedenSil_Click(object sender, EventArgs e)
        {

            try
            {
            var sarkiId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var sarkiTur = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            var calmaListesi = context.CalmaListesis.Where(x => x.ListeAd == sarkiTur && x.KullaniciID == _id).FirstOrDefault();
            var calmaListesiId = calmaListesi.CalmaListesiID;

            var calmaListesiSarkilar = context.CalmaListesiSarkilars.Where(x => x.SarkiID == sarkiId && x.CalmaListesiID == calmaListesiId).FirstOrDefault();
            var calmaListesiSarkilarId = calmaListesiSarkilar.CalmaListeSarkilarID;

            CalmaListesiSarkilarService calmaListesiSarkilarService = new CalmaListesiSarkilarService();

                calmaListesiSarkilarService.Delete(calmaListesiSarkilarId);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sarki Seciniz");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

