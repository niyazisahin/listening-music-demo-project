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

        private int _id;

        public KullaniciForm(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {           
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
            dataGridView1.DataSource = context.Sarkis.Where(x => x.SarkiTur == "Rock").ToList();
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
            ListeYazdir("Rock");
        }

        void ListeYazdir(string tur)
        {
            var calmaListesi = context.CalmaListesis.Where(x => x.KullaniciID == _id && x.ListeAd == tur).FirstOrDefault();
            var calmaListesiId = calmaListesi.CalmaListesiID;
            dataGridView1.DataSource = context.CalmaListesiSarkilars.Where(x => x.CalmaListesiID == calmaListesiId).ToList();
        }

        private void btnListeEkle_Click(object sender, EventArgs e)
        {
            var sarkiId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var sarkiTur = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            var calmaListesi = context.CalmaListesis.Where(x => x.ListeAd == sarkiTur).FirstOrDefault();
            var calmaListesiId = calmaListesi.CalmaListesiID;

            CalmaListeSarkilar calmaListesiSarkilar = new CalmaListeSarkilar();
            calmaListesiSarkilar.CalmaListesiID = Convert.ToInt32(calmaListesiId);
            calmaListesiSarkilar.SarkiID = sarkiId;

            CalmaListesiSarkilarService calmaListesiSarkilarService = new CalmaListesiSarkilarService();

            calmaListesiSarkilarService.Add(calmaListesiSarkilar);
        }
    }

}

