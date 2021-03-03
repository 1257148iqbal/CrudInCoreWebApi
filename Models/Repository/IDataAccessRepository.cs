using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudInCoreWebApi.Models.Repository
{
    public interface IDataAccessRepository<TEntity>
    {
        IEnumerable<TEntity> GelAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
