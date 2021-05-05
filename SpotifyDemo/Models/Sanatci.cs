using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class Sanatci
    {
        
        public virtual int SanatciID { get; set; }
        public string SanatciAd { get; set; }
        public string SanatciUlke { get; set; }
        public ICollection<Sarki> SanatciSarki { get; set; }

    }
}
