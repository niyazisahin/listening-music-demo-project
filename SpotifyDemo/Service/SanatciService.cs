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
    class SanatciService : IManager<Sanatci>
    {
        ContextClass context = new ContextClass();

        public void Add(Sanatci entity)
        {
            context.Sanatcis.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Sanatcis.Remove(GetByID(id));
            context.SaveChanges();
        }

        public Sanatci GetByID(int id)
        {
            var sanatci = context.Sanatcis.Where(x=>x.SanatciID == id).SingleOrDefault();
            return sanatci;
        }

        public void Update(int id, Sanatci entity)
        {
            var sanatci = context.Sanatcis.Where(x => x.SanatciID == id).SingleOrDefault();
            sanatci.SanatciAd = entity.SanatciAd;
            sanatci.SanatciUlke = entity.SanatciUlke;
            context.SaveChanges();
        }
    }
}
