using gRPC.TaskManagement.BL.Managers.Abstracts;
using gRPC.TaskManagement.BL.Managers.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace gRPC.TaskManagement.BL;

public static class BLDependancies
{
    public static IServiceCollection AddBLDependeces(this IServiceCollection services)
    {
        services.AddScoped<ICategoryManager, CategoryManager>();
        services.AddScoped<IProjectManager, ProjectManager>();
        return services;
    }
}