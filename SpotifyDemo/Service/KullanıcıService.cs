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
    class KullanıcıService : IManager<Kullanici>
    {
        ContextClass context = new ContextClass();
        public void Add(Kullanici entity)
        {
            context.Kullanicis.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var kullanici = GetByID(id);
            context.Kullanicis.Remove(kullanici);
            context.SaveChanges();
        }

        public Kullanici GetByID(int id)
        {
            var kullanici = context.Kullanicis.Where(x => x.KullaniciID == id).FirstOrDefault();
            return kullanici;
        }

        public void Update(int id, Kullanici entity)
        {
            var kullanici = GetByID(id);

            kullanici.KullaniciAd = entity.KullaniciAd;
            kullanici.KullaniciMail = entity.KullaniciMail;
            kullanici.KullaniciSifre = entity.KullaniciSifre;
            kullanici.KullaniciAbonelikTur = entity.KullaniciAbonelikTur;
            kullanici.KullaniciUlke = entity.KullaniciUlke;

            context.SaveChanges();
        }
    }
}
