using gRPC.TaskManagement.DAL.Repositories.Abstracts;

namespace gRPC.TaskManagement.DAL.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    Task Commit();

    void Rollback();

    IBaseRepository<TModel> GetRepository<TModel>() where TModel : class;
}