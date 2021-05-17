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
    class SarkiSanatcilarService : IManager<SarkiSanatcilar>
    {
        ContextClass context = new ContextClass();
        public void Add(SarkiSanatcilar entity)
        {
            context.SarkiSanatcilars.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var sarkiSanatcilar = GetByID(id);
            context.SarkiSanatcilars.Remove(sarkiSanatcilar);
            context.SaveChanges();
        }

        public SarkiSanatcilar GetByID(int id)
        {
            var sarkiSanatcilar = context.SarkiSanatcilars.Where(x => x.SarkiSanatcilarID == id).FirstOrDefault();
            return sarkiSanatcilar;
        }

        public void Update(int id, SarkiSanatcilar entity)
        {
            var sarkiSanatcilar = GetByID(id);

            sarkiSanatcilar.SarkiID = entity.SarkiID;
            sarkiSanatcilar.SanatciID = entity.SanatciID;


            context.SaveChanges();
        }
    }
}
