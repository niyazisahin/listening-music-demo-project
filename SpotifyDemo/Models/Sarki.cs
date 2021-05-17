using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Sarki
    {
        [DisplayName("ID")]
        public virtual int SarkiID { get; set; }

        [DisplayName("Şarkı Ad")]
        public string SarkiAd { get; set; }

        [DisplayName("Tarih")]
        public DateTime SarkiTarih { get; set; }

        [DisplayName("Tür")]
        public string SarkiTur { get; set; }

        [DisplayName("Süre")]
        public int SarkiSure { get; set; }

        [DisplayName("Dinlenme Sayısı")]
        public int SarkiDinlenmeSayisi { get; set; }
        public int AlbumID { get; set; }
        
    }
}
