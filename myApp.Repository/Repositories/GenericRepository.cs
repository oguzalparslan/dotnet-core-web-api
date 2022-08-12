using Microsoft.EntityFrameworkCore;
using myApp.Core.Repositories;

namespace myApp.Repository.Repositories
{
    public class Service<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbset;
        public Service(AppDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();

        }

        public async Task AddAsync(T entity)
        {
            await _dbset.AddAsync(entity);
        }

        public IQueryable<T> GetAllAsync()
        {
            return _dbset.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbset.FindAsync(id);
            return entity;
        }

        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbset.Update(entity);

        }
    }
}
