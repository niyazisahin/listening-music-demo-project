using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Takipler
    {
        [DisplayName("ID")]
        public int TakiplerID { get; set; }

        [DisplayName("Takip Eden")]
        public int TakipEdenID { get; set; }

        [DisplayName("Takip Edilen")]
        public int TakipEdilenID { get; set; }
    }
}
