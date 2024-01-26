using gRPC.TaskManagement.DAL.Enums;
using gRPC.TaskManagement.DAL.Models;

namespace gRPC.TaskManagement.BL.DTOs.CategoryDTOs;

public sealed record CreateCategoryDTO
    (string Name, string Description, TaskColor Color)
{
    public int Id { get; init; }
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public TaskColor Color { get; init; } = Color;

    public static implicit operator Category(CreateCategoryDTO categoryDTO)
        =>
        categoryDTO is not null ?
        new Category(categoryDTO.Name, categoryDTO.Description, categoryDTO.Color) :
        throw new ArgumentException(null, nameof(categoryDTO));
}