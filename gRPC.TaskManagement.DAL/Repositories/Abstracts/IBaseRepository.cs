using System.Linq.Expressions;

namespace gRPC.TaskManagement.DAL.Repositories.Abstracts;

public interface IBaseRepository<T> where T : class
{
    Task CreateAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(T entity);

    Task<T?> GetAsync(int id);

    Task<IQueryable<T>> GetAllAsync();

    Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> filter);

    Task<IQueryable<T>> GetAllWithPaging(int page, int limit);
}