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
    public partial class DigerKullaniciForm : Form
    {
        private int _id;
        ContextClass context = new ContextClass();
        TakiplerService takiplerService = new TakiplerService();



        public DigerKullaniciForm(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void DigerKullaniciForm_Load(object sender, EventArgs e)
        {
            LoadData();


            var kullanici = context.Kullanicis.Where(x => x.KullaniciID == _id).FirstOrDefault();
            var kullaniciAd = kullanici.KullaniciAd;

            lblKullaniciAd.Text = kullaniciAd;

            var kullanicilar = context.Kullanicis.Where(x => x.KullaniciAbonelikTur == "Premium").ToList();

            foreach (var item in kullanicilar)
            {
                if (item.KullaniciID != _id)
                {
                    cmbxKullanicilar.Items.Add(item.KullaniciAd);
                }
                
            }
            
        }

        private void cmbxKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kullanici = cmbxKullanicilar.Text;

        }

        private void btnTakipEt_Click(object sender, EventArgs e)
        {

            Takipler takip = new Takipler();

            var takipEden = context.Kullanicis.Where(x => x.KullaniciID == _id).FirstOrDefault();
            var takipEdenId = takipEden.KullaniciID;

            var takipEdilenAd = cmbxKullanicilar.Text;
            if (takipEdilenAd != "")
            {
                var takipEdilen = context.Kullanicis.Where(x => x.KullaniciAd == takipEdilenAd).FirstOrDefault();
                var takipEdilenId = takipEdilen.KullaniciID;


                takip.TakipEdenID = takipEdenId;
                takip.TakipEdilenID = takipEdilenId;

                var takipEdiliyorMu = context.Takiplers.Where(x => x.TakipEdenID == takipEdenId && x.TakipEdilenID == takipEdilenId).FirstOrDefault();

                if (takipEdiliyorMu == null)
                {
                    takiplerService.Add(takip);
                }
                else
                {
                    takiplerService.Delete(takipEdiliyorMu.TakiplerID);
                    MessageBox.Show(takipEdilen.KullaniciAd + " Adlı Kişiyi Takipten Çıktınız.");
                }

                LoadData();
            }
        }

        void LoadData()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            List<string> takipListeSon = new List<string>();

            var takipEdilenListe = context.Takiplers.Where(x => x.TakipEdenID == _id).ToList();
            var takipEdilenId = 0;


            foreach (var item in takipEdilenListe)
            {
                takipEdilenId = item.TakipEdilenID;
                var TakipEdilenAd = context.Kullanicis.Where(x => x.KullaniciID == takipEdilenId).FirstOrDefault();
                var TakipEdilenAd2 = TakipEdilenAd.KullaniciAd.ToString();

                takipListeSon.Add(TakipEdilenAd2);
            }



            foreach (var item in takipListeSon)
            {
                dataGridView2.Rows.Add(item);
            }
        }

        private void btnListeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sarkiId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var sarkiTur = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                SarkiListeEkle(sarkiId, sarkiTur);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sarki Seciniz.");
            }

        }

        void SarkiListeEkle(int sarkiId, string sarkiTur)
        {

            Console.WriteLine(sarkiId);
            Console.WriteLine(sarkiTur);

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTumSarkilar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            

            List<Sarki> pop = ListeYazdir("Pop");
            List<Sarki> caz = ListeYazdir("Caz");
            List<Sarki> klasik = ListeYazdir("Klasik");
            List<Sarki> tumSarkilar = new List<Sarki>();

            if (pop != null && caz != null && klasik != null)
            {
           tumSarkilar.AddRange(pop);
            tumSarkilar.AddRange(caz);
            tumSarkilar.AddRange(klasik); 
            }
 
                dataGridView1.DataSource = tumSarkilar;
            
        }

        private void btnPop_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            var sarkiListesi = ListeYazdir("Pop");

            if (sarkiListesi != null)
            {
                dataGridView1.DataSource = sarkiListesi;
            }
            
        }

        List<Sarki> ListeYazdir(string tur)
        {
            var kullaniciAd = dataGridView2.CurrentRow.Cells[0].Value;

            if (kullaniciAd != null)
            {
            var kullanici = context.Kullanicis.Where(x => x.KullaniciAd == kullaniciAd.ToString()).FirstOrDefault();
            var kullaniciId = kullanici.KullaniciID;
            ;

            var calmaListesi = context.CalmaListesis.Where(x => x.KullaniciID == kullaniciId && x.ListeAd == tur).FirstOrDefault();
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

            return sarkiListesi;
            }

            return null;
            
        }

        private void btnCaz_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            var sarkiListesi = ListeYazdir("Caz");

            if (sarkiListesi != null)
            {
                dataGridView1.DataSource = sarkiListesi;
            }
        }

        private void btnKlasik_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            var sarkiListesi = ListeYazdir("Klasik");

            if (sarkiListesi != null)
            {
                dataGridView1.DataSource = sarkiListesi;
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            KullaniciForm kullaniciForm = new KullaniciForm(_id);
            this.Hide();
            kullaniciForm.ShowDialog();
            this.Close();
        }

        private void btnTumunuEKle_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                var sarkiId = Convert.ToInt32(item.Cells[0].Value);
                var sarkiTur = item.Cells[3].Value.ToString();

                SarkiListeEkle(sarkiId, sarkiTur);
            }
        }
    }
}
