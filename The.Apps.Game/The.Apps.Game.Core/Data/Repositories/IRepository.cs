using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace The.Apps.Game.Core.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Create(T model);
        void Create(ICollection<T> models);

        IQueryable<T> Read();
        IQueryable<T> Read(Expression<Func<T, bool>> expression);        

        void Update(T model);
        void Update(ICollection<T> models);

        void Delete(T model);
        void Delete(ICollection<T> models);
    }
}
