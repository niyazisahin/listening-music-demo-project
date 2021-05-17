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
    class TakiplerService : IManager<Takipler>
    {
        ContextClass context = new ContextClass();
        public void Add(Takipler entity)
        {
            context.Takiplers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var takipler = GetByID(id);

            context.Takiplers.Remove(takipler);
            context.SaveChanges();
        }

        public Takipler GetByID(int id)
        {
            var takipler = context.Takiplers.Where(x => x.TakiplerID == id).FirstOrDefault();
            return takipler;
        }

        public void Update(int id, Takipler entity)
        {
            var takipler = GetByID(id);

            takipler.TakipEdenID = entity.TakipEdenID;
            takipler.TakipEdilenID = takipler.TakipEdilenID;

            context.SaveChanges();
        }
    }
}
