using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Sarki
    {
        public virtual int SarkiID { get; set; }
        public string SarkiAd { get; set; }
        public DateTime SarkiTarih { get; set; }
        public string SarkiTur { get; set; }
        public int SarkiSure { get; set; }
        public int SarkiDinlenmeSayisi { get; set; }
        public int AlbumID { get; set; }
        
    }
}
