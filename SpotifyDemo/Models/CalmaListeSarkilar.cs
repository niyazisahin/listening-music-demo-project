using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class CalmaListeSarkilar
    {
        [DisplayName("ID")]
        public int CalmaListeSarkilarID { get; set; }

        [DisplayName("Çalma Listesi")]
        public int CalmaListesiID { get; set; }

        [DisplayName("Şarkı")]
        public int SarkiID { get; set; }
    }
}
