using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace The.Apps.Game.Core.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }
        public void Create(ICollection<T> models)
        {
            Context.Set<T>().AddRange(models);
        }

        public void Create(T model)
        {
            Context.Set<T>().Add(model);
        }

        public void Delete(ICollection<T> models)
        {
            Context.Set<T>().RemoveRange(models);
        }

        public void Delete(T model)
        {
            Context.Set<T>().Remove(model);
        }

        public IQueryable<T> Read()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> Read(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression);
        }

        public void Update(ICollection<T> models)
        {
            Context.Entry(models).State = EntityState.Modified;
        }

        public void Update(T model)
        {
            Context.Entry(model).State = EntityState.Modified;
        }
    }
}
