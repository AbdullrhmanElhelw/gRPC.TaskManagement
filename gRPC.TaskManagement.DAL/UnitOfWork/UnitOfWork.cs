using gRPC.TaskManagement.DAL.Context;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;
using gRPC.TaskManagement.DAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace gRPC.TaskManagement.DAL.UnitOfWork;

public class UnitOfWork
    : IUnitOfWork
{
    private readonly TaskManagementDbContext _context;
    private Dictionary<Type, object> _repos;

    public UnitOfWork(TaskManagementDbContext context)
    {
        _context = context;
        _repos = [];
    }

    public async Task Commit() =>
        await _context.SaveChangesAsync();

    public void Dispose() =>
        _context.Dispose();

    public IBaseRepository<TModel> GetRepository<TModel>() where TModel : class
    {
        if (_repos.ContainsKey(typeof(TModel)))
        {
            return (IBaseRepository<TModel>)_repos[typeof(TModel)];
        }
        var repo = new BaseRepository<TModel>(_context);
        _repos.Add(typeof(TModel), repo);
        return repo;
    }

    public void Rollback()
    {
        _context.ChangeTracker.Entries()
            .Where(e => e.Entity != null).ToList()
            .ForEach(e => e.State = EntityState.Detached);
    }
}