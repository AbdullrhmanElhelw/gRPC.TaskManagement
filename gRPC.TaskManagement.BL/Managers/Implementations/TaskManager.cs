using gRPC.TaskManagement.BL.DTOs.TaskDTOs;
using gRPC.TaskManagement.BL.Managers.Abstracts;
using gRPC.TaskManagement.DAL.Models;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;
using gRPC.TaskManagement.DAL.UnitOfWork;

namespace gRPC.TaskManagement.BL.Managers.Implementations;

public class TaskManager
    : ITaskManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBaseRepository<TaskItem> _repository;

    public TaskManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _repository = _unitOfWork.GetRepository<TaskItem>();
    }

    public async Task CreateTask(CreateTaskDTO createTask)
    {
        if (createTask is null)
            throw new ArgumentNullException(nameof(createTask));

        await _repository.CreateAsync(createTask);
        await _unitOfWork.Commit();
    }
}