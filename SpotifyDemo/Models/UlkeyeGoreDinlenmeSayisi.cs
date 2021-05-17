using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class UlkeyeGoreDinlenmeSayisi
    {
        [DisplayName("ID")]
        public int UlkeyeGoreDinlenmeSayisiID { get; set; }

        [DisplayName("Şarkı")]
        public int SarkiID { get; set; }

        [DisplayName("Ülke")]
        public string UlkeAd { get; set; }

        [DisplayName("Dinlenme Sayısı")]
        public int DinlenmeSayisi { get; set; }

    }
}
