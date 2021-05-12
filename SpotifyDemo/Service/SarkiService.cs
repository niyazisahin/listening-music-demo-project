using SpotifyDemo.Context;
using SpotifyDemo.Core;
using SpotifyDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Service
{
    class SarkiService : IManager<Sarki>
    {
        ContextClass context = new ContextClass();
        public void Add(Sarki entity)
        {
            context.Sarkis.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var sarki = GetByID(id);
            context.Sarkis.Remove(sarki);
            context.SaveChanges();
        }

        public Sarki GetByID(int id)
        {
            var sarki = context.Sarkis.Where(x => x.SarkiID == id).FirstOrDefault();
            return sarki;
        }

        public void Update(int id, Sarki entity)
        {
            var sarki = GetByID(id);
            sarki.SarkiAd = entity.SarkiAd;
            sarki.AlbumID = entity.AlbumID;
            sarki.SarkiSure = entity.SarkiSure;
            sarki.SarkiTarih = entity.SarkiTarih;
            sarki.SarkiTur = entity.SarkiTur;

            context.SaveChanges();
        }
    }
}
