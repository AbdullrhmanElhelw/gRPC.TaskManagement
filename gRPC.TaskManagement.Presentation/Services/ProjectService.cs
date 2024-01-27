using gRPC.TaskManagement.BL.DTOs.ProjectDTOs;
using gRPC.TaskManagement.BL.Managers.Abstracts;
using Grpc.Core;

namespace gRPC.TaskManagement.Presentation.Services;

public class ProjectService(IProjectManager projectManager)
    : ProjectItemService.ProjectItemServiceBase
{
    private readonly IProjectManager _projectManager = projectManager;

    public override async Task<CreateProjectResponse> CreateProject(CreateProjectRequest request, ServerCallContext context)
    {
        var projectToCreate = new CreateProjectDTO
            (request.Name, request.Description, request.StartDate.ToDateTime(), request.EndDate.ToDateTime());

        await _projectManager.CreateProject(projectToCreate);
        return new CreateProjectResponse
        {
            Status = 200
        };
    }

    public override async Task<GetProjectResponse> GetProject(GetProjectRequest request, ServerCallContext context)
    {
        var project = await _projectManager.GetProject(request.Id);

        return new GetProjectResponse
        {
            Id = project.Id,
            Name = project.Name,
            Description = project.Description
        };
    }

    public override async Task GetallProjects(GetallProjectsRequest request, IServerStreamWriter<GetProjectResponse> responseStream, ServerCallContext context)
    {
        var projects = await _projectManager.GetAll();
        foreach (var project in projects)
        {
            await responseStream.WriteAsync(new GetProjectResponse
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description
            });
        }
    }
}