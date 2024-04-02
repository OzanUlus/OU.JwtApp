using Microsoft.EntityFrameworkCore;
using OU.JwtApp.Back.Core.Application.Interfaces;
using OU.JwtApp.Back.Persistance.Context;
using System.Linq.Expressions;

namespace OU.JwtApp.Back.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly JwtContext _jwtContext;
        private readonly DbSet<T> _dbSet;

        public Repository(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
            _dbSet = jwtContext.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _jwtContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
           _dbSet.Remove(entity);
            await _jwtContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _jwtContext.SaveChangesAsync();
        }
    }
}
