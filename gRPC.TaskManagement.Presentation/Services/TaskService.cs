using gRPC.TaskManagement.BL.DTOs.TaskDTOs;
using gRPC.TaskManagement.BL.Managers.Abstracts;
using Grpc.Core;
using domainEnum = gRPC.TaskManagement.DAL.Enums;

namespace gRPC.TaskManagement.Presentation.Services;

public class TaskService(ITaskManager taskManager)
    : TaskItemService.TaskItemServiceBase
{
    private readonly ITaskManager _taskManager = taskManager;

    public override async Task<CreateTaskResponse> CreateTask(CreateTaskRequest request, ServerCallContext context)
    {
        var taskToCreate = MapCreateTaskRequestToDTO(request);

        await _taskManager.CreateTask(taskToCreate);

        return new CreateTaskResponse
        {
            Status = 200
        };
    }

    private static CreateTaskDTO MapCreateTaskRequestToDTO(CreateTaskRequest request)
    {
        var statusToEnum = (domainEnum.Status)request.Status;
        var priorityToEnum = (domainEnum.Priority)request.Priority;

        return new CreateTaskDTO
            (Status: statusToEnum, Priority: priorityToEnum, Name: request.Name, Description: request.Description,
                           CategoryId: request.CategoryId, ProjectId: request.ProjectId);
    }
}