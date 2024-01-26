using gRPC.TaskManagement.DAL.Context;
using gRPC.TaskManagement.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace gRPC.TaskManagement.DAL;

public static class DALDependences
{
    public static IServiceCollection AddDALDependences(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        services.AddDbContext<TaskManagementDbContext>(op =>
             op.UseSqlServer(configuration.GetConnectionString("TaskDb"))
             );
        return services;
    }
}