using gRPC.TaskManagement.BL.DTOs.TaskDTOs;

namespace gRPC.TaskManagement.BL.Managers.Abstracts;

public interface ITaskManager
{
    Task CreateTask(CreateTaskDTO createTask);
}