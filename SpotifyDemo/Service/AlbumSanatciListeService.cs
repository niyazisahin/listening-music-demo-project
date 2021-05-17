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
    class AlbumSanatciListeService : IManager<AlbumSanatciListe>
    {
        ContextClass context = new ContextClass();
        public void Add(AlbumSanatciListe entity)
        {
            context.AlbumSanatciListes.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var liste = GetByID(id);
            context.AlbumSanatciListes.Remove(liste);

            context.SaveChanges();
        }

        public AlbumSanatciListe GetByID(int id)
        {
            var liste = context.AlbumSanatciListes.Where(x => x.AlbumSanatciListeID == id).FirstOrDefault();

            return liste;
        }

        public void Update(int id, AlbumSanatciListe entity)
        {
            var liste = GetByID(id);

            liste.AlbumID = entity.AlbumID;
            liste.SanatciID = entity.SanatciID;

            context.SaveChanges();
        }
    }
}
