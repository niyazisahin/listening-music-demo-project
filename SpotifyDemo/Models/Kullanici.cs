using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    public class Kullanici
    {
        [DisplayName("ID")]
        public int KullaniciID { get; set; }

        [DisplayName("Ad")]
        public string KullaniciAd { get; set; }

        [DisplayName("Mail")]
        public string KullaniciMail { get; set; }

        [DisplayName("Şifre")]
        public string KullaniciSifre { get; set; }

        [DisplayName("Abonelik Tür")]
        public string KullaniciAbonelikTur { get; set; }

        [DisplayName("Ülke")]
        public string KullaniciUlke { get; set; }

        public bool OdendiMi { get; set; }



    }
}
