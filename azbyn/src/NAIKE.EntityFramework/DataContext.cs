using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace NAIKE.EntityFramework
{
    public class DataContext<TEntity> : DbContext, IDataRepository<TEntity>, IUnitOfWork 
        where TEntity : class
    {
        public DataContext(DbContextOptions<DataContext<TEntity>> contextOptions) : base(contextOptions)
        {

        }

        public void Commit()
        {
            SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Delete(entity);
        }

        public TEntity Insert(TEntity entity)
        {
            return Insert(entity);
        }


        public IQueryable<TEntity> Query()
        {
            return Set<TEntity>();
        }

        void IDataRepository<TEntity>.Update(TEntity entity)
        {
            Update(entity);
        }

    }
}
