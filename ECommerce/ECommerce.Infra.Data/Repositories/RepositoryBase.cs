using ECommerce.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using ECommerce.Infra.Data.Contexts;
using System.Linq;
using System.Collections.Generic;

namespace ECommerce.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected Context Db;

        public IQueryable<TEntity> Query => Db.Set<TEntity>();

        public RepositoryBase(IConfiguration configuration)
        {
            if (Db == null)
                Db = new Context(configuration);
        }

        public virtual TEntity GetById(int id)
            => Db.Set<TEntity>().Find(id);

        public virtual List<TEntity> GetAll()
            => Db.Set<TEntity>().ToList();

        public void Dispose()
        {
            IDisposable d = Db as IDisposable;
            if (d != null)
                d.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
