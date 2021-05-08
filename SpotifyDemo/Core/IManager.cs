using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.Core
{
   interface IManager<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
        TEntity GetByID(int id);
        
    }
}
