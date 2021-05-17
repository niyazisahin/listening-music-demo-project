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
    class UlkeyeGoreDinlenmeService : IManager<UlkeyeGoreDinlenmeSayisi>
    {
        ContextClass context = new ContextClass();
        public void Add(UlkeyeGoreDinlenmeSayisi entity)
        {
            context.UlkeyeGoreDinlenmeSayisis.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetByID(id);
            context.UlkeyeGoreDinlenmeSayisis.Remove(entity);
            context.SaveChanges();
        }

        public UlkeyeGoreDinlenmeSayisi GetByID(int id)
        {
            var entity = context.UlkeyeGoreDinlenmeSayisis.Where(x => x.UlkeyeGoreDinlenmeSayisiID == id).FirstOrDefault();

            return entity;
        }

        public void Update(int id, UlkeyeGoreDinlenmeSayisi entity)
        {
            var entityEski = GetByID(id);

            entityEski.SarkiID = entity.SarkiID;
            entityEski.UlkeAd = entity.UlkeAd;
            entityEski.DinlenmeSayisi = entity.DinlenmeSayisi;

            context.SaveChanges();
        }
    }
}
