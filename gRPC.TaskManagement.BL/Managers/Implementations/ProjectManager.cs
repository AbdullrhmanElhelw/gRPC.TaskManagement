using gRPC.TaskManagement.BL.DTOs.ProjectDTOs;
using gRPC.TaskManagement.BL.Managers.Abstracts;
using gRPC.TaskManagement.DAL.Models;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;
using gRPC.TaskManagement.DAL.UnitOfWork;

namespace gRPC.TaskManagement.BL.Managers.Implementations;

public class ProjectManager
    : IProjectManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBaseRepository<Project> _repository;

    public ProjectManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _repository = _unitOfWork.GetRepository<Project>();
    }

    public async Task CreateProject(CreateProjectDTO projectDTO)
    {
        await _repository.CreateAsync(projectDTO);
        await _unitOfWork.Commit();
    }

    public async Task DeleteProject(int id)
    {
        var projectIsExist = await _repository.GetAsync(id);
        if (projectIsExist is null)
            throw new NullReferenceException(nameof(projectIsExist));

        await _repository.DeleteAsync(projectIsExist);
        await _unitOfWork.Commit();
    }

    public async Task<IQueryable<ReadProjectDTO>> GetAll()
    {
        var projects = await _repository.GetAllAsync();
        return projects.ToReadProjectDTO();
    }

    public async Task<ReadProjectDTO?> GetProject(int id)
    {
        var project = await _repository.GetAsync(id);
        if (project is null)
            throw new NullReferenceException(nameof(project));

        return project;
    }
}