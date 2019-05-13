using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KrakenNotes.Services.Interfaces
{
    /// <summary>
    /// The main interface in Repository pattern.
    /// </summary>
    /// <typeparam name="TEntity">The type that repository is for.</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
