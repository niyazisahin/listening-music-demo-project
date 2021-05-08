﻿using SpotifyDemo.Context;
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

            foreach (var item in context.Admins)
            {
                if (item.AdminMail == mail)
                {
                    if (item.AdminSifre == sifre)
                    {
                        Console.WriteLine("Admin Giris Basarili");
                        AdminForm adminForm = new AdminForm();
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}