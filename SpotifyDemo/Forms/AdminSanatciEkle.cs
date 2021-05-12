﻿using SpotifyDemo.Context;
using SpotifyDemo.Models;
using SpotifyDemo.Service;
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

namespace SpotifyDemo.Forms
{
    public partial class AdminSanatciEkle : Form
    {

        Ping p = new Ping();
        ContextClass context = new ContextClass();
        SanatciService service = new SanatciService();

        public AdminSanatciEkle()
        {
            InitializeComponent();
        }

        private void btnAdminAnasayfaDon_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            this.Hide();
            adminAnasayfa.ShowDialog();
            this.Close();
        }

        private void lblPing_Click(object sender, EventArgs e)
        {
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());
        }

        private void lblPingYazi_Click(object sender, EventArgs e)
        {
            PingReply rep = p.Send("www.google.com");
            lblPing.Text = (rep.RoundtripTime.ToString());
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            Sanatci sanatci = new Sanatci();

            sanatci.SanatciAd = tbxSanatciAd.Text;
            sanatci.SanatciUlke = tbxSanatciUlke.Text;

            try
            {
                service.Add(sanatci);
            }
            catch 
            {
                MessageBox.Show("Sanatci Eklenemedi");
            }
            MessageBox.Show("Sanatci Eklendi");
        }
    }
}
