using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Album
    {
        public int AlbumID { get; set; }
        public string AlbumAd { get; set; }
        public   Sanatci AlbumSanatci { get; set; }
        public  ICollection<Sarki> AlbumSarki { get; set; }
        


    }
}
