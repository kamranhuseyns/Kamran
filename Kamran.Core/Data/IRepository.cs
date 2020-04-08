using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamran.Core.Data
{
    public partial interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(object id);

        void Insert(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> TableNoTracking { get; }
    }
}
