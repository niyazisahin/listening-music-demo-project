using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class CalmaListeSarkilar
    {
        [Key]
        public int CalmaListeSarkilarID { get; set; }
        public CalmaListesi CalmaListesiID { get; set; }
        public Sarki SarkiID { get; set; }
    }
}
