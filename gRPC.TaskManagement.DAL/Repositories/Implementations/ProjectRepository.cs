using gRPC.TaskManagement.DAL.Context;
using gRPC.TaskManagement.DAL.Models;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;

namespace gRPC.TaskManagement.DAL.Repositories.Implementations;

public class ProjectRepository(TaskManagementDbContext context)
    : BaseRepository<Project>(context)
    , IProjectRepository
{
}