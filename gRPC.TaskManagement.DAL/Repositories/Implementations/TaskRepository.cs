using gRPC.TaskManagement.DAL.Context;
using gRPC.TaskManagement.DAL.Models;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;

namespace gRPC.TaskManagement.DAL.Repositories.Implementations;

public class TaskRepository(TaskManagementDbContext context)
    : BaseRepository<TaskItem>(context)
    , ITaskRepository
{
}