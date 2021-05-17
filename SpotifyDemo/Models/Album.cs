using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Album
    {
        [DisplayName("ID")]
        public int AlbumID { get; set; }

        [DisplayName("Ad")]
        public string AlbumAd { get; set; }
        
        
        


    }
}
