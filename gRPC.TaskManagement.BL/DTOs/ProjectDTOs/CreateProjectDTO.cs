using gRPC.TaskManagement.DAL.Models;

namespace gRPC.TaskManagement.BL.DTOs.ProjectDTOs;

public record CreateProjectDTO
    (string Name, string Description, DateTime StartDate, DateTime EndDate)
{
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public DateTime StartDate { get; init; } = StartDate;
    public DateTime EndDate { get; init; } = EndDate;

    public static implicit operator Project(CreateProjectDTO projectDTO)
        =>
        new(projectDTO.Name, projectDTO.Description, projectDTO.StartDate, projectDTO.EndDate);
}