using SpotifyDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Context
{
    class ContextClass:DbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Sarki> Sarkis { get; set; }
        public DbSet<Sanatci> Sanatcis { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<CalmaListesi> CalmaListesis { get; set; }
        public DbSet<CalmaListeSarkilar> CalmaListesiSarkilars { get; set; }
        public DbSet<SarkiSanatcilar> SarkiSanatcilars { get; set; }
    }
}
