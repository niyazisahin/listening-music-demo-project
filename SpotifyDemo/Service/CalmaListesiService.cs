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
    class CalmaListesiService : IManager<CalmaListesi>
    {
        ContextClass context = new ContextClass();
        public void Add(CalmaListesi entity)
        {
            context.CalmaListesis.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var calmaListesi = GetByID(id);
            context.CalmaListesis.Remove(calmaListesi);

            context.SaveChanges();
        }

        public CalmaListesi GetByID(int id)
        {
            var calmaListesi = context.CalmaListesis.Where(x => x.CalmaListesiID == id).FirstOrDefault();
            
            return calmaListesi;
        }

        public void Update(int id, CalmaListesi entity)
        {
            var calmaListesi = GetByID(id);
            calmaListesi.ListeAd = entity.ListeAd;

            context.SaveChanges();
        }
    }
}
