using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsApp.DAL
{
    public interface IEntityRepository<TEntity>
        where TEntity: EntityBase
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> AddAsync(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
        Task<int> SaveChanges();
    }
}
