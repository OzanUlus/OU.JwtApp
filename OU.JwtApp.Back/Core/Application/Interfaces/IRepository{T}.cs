using System.Linq.Expressions;

namespace OU.JwtApp.Back.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class,new()
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);  
        Task RemoveAsync(T entity);
        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByFilterAsync(Expression<Func<T , bool>> filter);
        Task<List<T>> GetAllAsync();
    }
}
