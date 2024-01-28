namespace gRPC.TaskManagement.BL.DTOs.ProjectDTOs;

public sealed record UpdateProjectDTO
    (string Name, string Description, DateTime StartDate, DateTime EndDate)
{
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public DateTime StartDate { get; init; } = StartDate;
    public DateTime EndDate { get; init; } = EndDate;
}