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

namespace SpotifyDemo
{
    public partial class AdminForm : Form
    {
        ContextClass context = new ContextClass();
        SanatciService sanatciService = new SanatciService();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnSarkiciEkle_Click(object sender, EventArgs e)
        {
            Sanatci sanatci = new Sanatci();
            sanatci.SanatciAd = tbxSarkiciAd.Text;
            sanatci.SanatciUlke = tbxSarkiciUlke.Text;

            sanatciService.Add(sanatci);

        }

        private void btnSanatciGuncelle_Click(object sender, EventArgs e)
        {
            Sanatci sanatci = new Sanatci();

            sanatci.SanatciAd = tbxSanatciAD.Text;
            sanatci.SanatciUlke = tbxSanatciULKE.Text;

            sanatciService.Update(Int32.Parse(tbxSanatciID.Text), sanatci);
        }
    }
}
