using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAIKE.EntityFramework
{
    public interface IDataRepository<TEntity>
    {
        IQueryable<TEntity> Query();
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity Insert(TEntity entity);
    }
}
