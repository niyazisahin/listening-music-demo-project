using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class CalmaListesi
    {

        [DisplayName("ID")]
        public int CalmaListesiID { get; set; }

        [DisplayName("Kullanıcı")]
        public int KullaniciID { get; set; }

        [DisplayName("Liste")]
        public string ListeAd { get; set; }
    }
}
