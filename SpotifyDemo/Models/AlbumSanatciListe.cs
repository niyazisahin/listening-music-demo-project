using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class AlbumSanatciListe
    {

        [DisplayName("ID")]
        public int AlbumSanatciListeID { get; set; }

        [DisplayName("Albüm")]
        public int AlbumID { get; set; }

        [DisplayName("Sanatçı")]
        public int SanatciID { get; set; }
    }
}
