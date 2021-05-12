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
    class AlbumService : IManager<Album>
    {
        ContextClass context = new ContextClass();
        public void Add(Album entity)
        {
            context.Albums.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var album = GetByID(id);
            context.Albums.Remove(album);
            context.SaveChanges();
        }

        public Album GetByID(int id)
        {
            var album = context.Albums.Where(x => x.AlbumID == id).FirstOrDefault();
            return album;
        }

        public void Update(int id, Album entity)
        {
            var album = GetByID(id);

            album.AlbumAd = entity.AlbumAd;
            album.AlbumSanatciID = entity.AlbumSanatciID;
            

            context.SaveChanges();


        }
    }
}
