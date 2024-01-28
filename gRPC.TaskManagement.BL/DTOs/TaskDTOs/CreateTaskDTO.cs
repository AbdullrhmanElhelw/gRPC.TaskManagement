using gRPC.TaskManagement.DAL.Enums;
using gRPC.TaskManagement.DAL.Models;

namespace gRPC.TaskManagement.BL.DTOs.TaskDTOs;

public sealed record CreateTaskDTO
    (string Name, string Description, Status Status, Priority Priority, int CategoryId, int ProjectId)
{
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public Status Status { get; init; } = Status;
    public Priority Priority { get; init; } = Priority;
    public int CategoryId { get; init; } = CategoryId;
    public int ProjectId { get; init; } = ProjectId;

    public static implicit operator TaskItem(CreateTaskDTO dto) =>
        new(dto.Name, dto.Description, dto.Status, dto.Priority)
        {
            CategoryId = dto.CategoryId,
            ProjectId = dto.ProjectId
        };
}