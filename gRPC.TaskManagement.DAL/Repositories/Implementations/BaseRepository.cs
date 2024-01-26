using gRPC.TaskManagement.DAL.Context;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace gRPC.TaskManagement.DAL.Repositories.Implementations;

public class BaseRepository<TModel>(TaskManagementDbContext context)
    : IBaseRepository<TModel> where TModel : class
{
    private readonly TaskManagementDbContext _context = context;

    public async Task CreateAsync(TModel entity) =>
        await _context.Set<TModel>().AddAsync(entity);

    public Task DeleteAsync(TModel entity)
    {
        _context.Set<TModel>().Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<TModel?> GetAsync(int id)
    {
        var result = await _context.Set<TModel>().FindAsync(id);
        return result;
    }

    public async Task<IQueryable<TModel>> GetAllAsync()
    {
        return await Task.FromResult(_context.Set<TModel>().AsQueryable());
    }

    public Task UpdateAsync(TModel entity)
    {
        _context.Set<TModel>().Update(entity);
        return Task.CompletedTask;
    }

    public async Task<IQueryable<TModel>> FindAsync(Expression<Func<TModel, bool>> filter)
    {
        var result = await _context.Set<TModel>().Where(filter).AsNoTracking().ToListAsync();
        return result.AsQueryable();
    }
}