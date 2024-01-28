using Google.Protobuf.WellKnownTypes;
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

    public override async Task FindProjectByName(FindProjectByNameRequest request, IServerStreamWriter<FindProjectByNameResponse> responseStream, ServerCallContext context)
    {
        var projects = await _projectManager.FindProjectByName(request.Name);

        foreach (var project in projects)
        {
            await responseStream.WriteAsync(new FindProjectByNameResponse
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description
            });
        }
    }

    public override async Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest request, ServerCallContext context)
    {
        var projectToUpdate = new UpdateProjectDTO
           (request.Name, request.Description, request.StartDate.ToDateTime(), request.EndDate.ToDateTime());

        await _projectManager.UpdateProject(request.Id, projectToUpdate);
        return new UpdateProjectResponse
        {
            Name = projectToUpdate.Name,
            Description = projectToUpdate.Description,
            StartDate = projectToUpdate.StartDate.ToTimestamp(),
            EndDate = projectToUpdate.EndDate.ToTimestamp()
        };
    }

    public override async Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest request, ServerCallContext context)
    {
        await _projectManager.DeleteProject(request.Id);
        return new DeleteProjectResponse
        {
            Status = 200
        };
    }
}