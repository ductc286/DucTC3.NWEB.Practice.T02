﻿namespace DucTC3.NWEB.Practice.T02.DataAccessLayer.Repositories
{
    using DucTC3.NWEB.Practice.T02.Core.Models;
    using global::NWEB.Practice.T02.DataAccessLayer;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly MyBaseDbContext MyDbContext;
        protected readonly DbSet<TEntity> MyDbSet;
        protected GenericRepository()
        {
            MyDbContext = new MyBaseDbContext();
            MyDbSet = MyDbContext.Set<TEntity>();
        }

        public virtual TEntity Find(object id)
        {
            return MyDbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return MyDbSet.ToList();
        }

        public virtual IQueryable<TEntity> FindAll()
        {
            return MyDbSet;
        }

        public virtual int Add(TEntity entity)
        {
            MyDbSet.Add(entity);
            return MyDbContext.SaveChanges();
        }

        public virtual bool Update(TEntity entity)
        {
            MyDbSet.AddOrUpdate(entity);
            return MyDbContext.SaveChanges() > 0;
        }

        public virtual bool Delete(TEntity entity)
        {
            MyDbSet.Remove(entity);
            return MyDbContext.SaveChanges() > 0;
        }
        public virtual void Dispose()
        {
            MyDbContext.Dispose();
        }
    }
}
