﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Models
{
    class SarkiSanatcilar
    {
        [DisplayName("ID")]
        public int SarkiSanatcilarID { get; set; }

        [DisplayName("Şarkı")]
        public int SarkiID { get; set; }

        [DisplayName("Sanatçı")]
        public int SanatciID { get; set; }
    }
}
