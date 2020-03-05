using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApsApp.DAL
{
    public class EntityRepository<T> : IEntityRepository<T>
        where T : EntityBase
    {
        private readonly AppDbContext _context;

        public EntityRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll() => _context.Set<T>();

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            var query = _context.Set<T>().Where(predicate);
            return query;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await GetAll().SingleOrDefaultAsync<T>(item => item.Id == id);
            return entity;
        }

        public async Task<T> AddAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            return item;
        }

        public void Update(T item) => _context.Entry(item).State = EntityState.Modified;

        public void Delete(T item) => _context.Set<T>().Remove(item);

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
