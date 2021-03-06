using ngApp.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ngApp.Web.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : EntityId
    {
        TEntity Get(long id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // This method was not in the videos, but I thought it would be useful to add.
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}