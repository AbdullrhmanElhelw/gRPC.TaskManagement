using gRPC.TaskManagement.BL.DTOs.ProjectDTOs;

namespace gRPC.TaskManagement.BL.Managers.Abstracts;

public interface IProjectManager
{
    Task CreateProject(CreateProjectDTO projectDTO);

    Task<ReadProjectDTO?> GetProject(int id);

    Task<IQueryable<ReadProjectDTO>> GetAll();

    Task DeleteProject(int id);

    Task UpdateProject(int id, UpdateProjectDTO projectDTO);

    Task<IQueryable<ReadProjectDTO>> FindProjectByName(string name);
}