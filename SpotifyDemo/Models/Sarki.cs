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
        public virtual Album SarkiAlbum { get; set; }
        //public ICollection<Sanatci> SarkiSanatci { get; set; }
        public string SarkiTur { get; set; }
        public float SarkiSure { get; set; }
        public int SarkiDinlenmeSayisi { get; set; }
    }
}
