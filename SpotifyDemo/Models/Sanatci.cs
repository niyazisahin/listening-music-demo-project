using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Sanatci
    {
        [DisplayName("ID")]
        public  int SanatciID { get; set; }

        [DisplayName("Ad")]
        public string SanatciAd { get; set; }

        [DisplayName("Ülke")]
        public string SanatciUlke { get; set; }
        

    }
}
