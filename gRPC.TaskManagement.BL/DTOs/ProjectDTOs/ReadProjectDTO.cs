using gRPC.TaskManagement.DAL.Models;

namespace gRPC.TaskManagement.BL.DTOs.ProjectDTOs;

public sealed record ReadProjectDTO
    (int Id, string Name, string Description, DateTime StartDate, DateTime EndDate)
{
    public int Id { get; init; } = Id;
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public DateTime StartDate { get; init; } = StartDate;
    public DateTime EndDate { get; init; } = EndDate;

    public static implicit operator ReadProjectDTO(Project project)
        => new(project.Id, project.Name, project.Description, project.StartDate, project.EndDate);
}

public static class ReadProjectDTOMapping
{
    public static IQueryable<ReadProjectDTO> ToReadProjectDTO(this IQueryable<Project> projects)
        => projects.Select(x => new ReadProjectDTO(x.Id, x.Name, x.Description, x.StartDate, x.EndDate));
}