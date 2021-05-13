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
    class CalmaListesiSarkilarService : IManager<CalmaListeSarkilar>
    {
        ContextClass context = new ContextClass();
        public void Add(CalmaListeSarkilar entity)
        {
            context.CalmaListesiSarkilars.Add(entity);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var calmaListesiSarki = GetByID(id);
            context.CalmaListesiSarkilars.Remove(calmaListesiSarki);

            context.SaveChanges();
        }

        public CalmaListeSarkilar GetByID(int id)
        {
            var calmaListesiSarki = context.CalmaListesiSarkilars.Where(x => x.CalmaListeSarkilarID == id).FirstOrDefault();

            return calmaListesiSarki;
        }

        public void Update(int id, CalmaListeSarkilar entity)
        {
            // Bos Metot.
        }
    }
}
