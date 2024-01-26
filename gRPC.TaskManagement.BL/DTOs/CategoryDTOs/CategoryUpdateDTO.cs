using gRPC.TaskManagement.DAL.Enums;

namespace gRPC.TaskManagement.BL.DTOs.CategoryDTOs;

public record CategoryUpdateDTO
    (int Id, string Name, string Description, TaskColor Color)
{
    public int Id { get; init; } = Id;
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public TaskColor Color { get; init; } = Color;
}