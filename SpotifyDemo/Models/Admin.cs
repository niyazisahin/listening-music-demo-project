using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Admin
    {
        [DisplayName("ID")]
        public int AdminID { get; set; }

        [DisplayName("Ad")]
        public string AdminAd { get; set; }

        [DisplayName("Mail")]
        public string AdminMail { get; set; }

        [DisplayName("Şifre")]
        public string AdminSifre { get; set; }
    }
}
