using gRPC.TaskManagement.DAL.Models;

namespace gRPC.TaskManagement.BL.DTOs.CategoryDTOs;

public sealed record CategoryReadDTO(int Id, string Name, string Description, string Color)
{
    public int Id { get; init; } = Id;
    public string Name { get; init; } = Name;
    public string Description { get; init; } = Description;
    public string Color { get; init; } = Color;

    public static implicit operator CategoryReadDTO(Category? category) =>
       category is not null ?
            new(category.Id, category.Name, category.Description, nameof(category.Color)) :
            throw new ArgumentNullException(nameof(category));
}

public static class CategoryReadDTOMapping
{
    public static IQueryable<CategoryReadDTO> ToCategoryReadDTO(this IQueryable<Category> categories)
    {
        return categories.Select(category => new CategoryReadDTO(category.Id, category.Name, category.Description, nameof(category.Color)));
    }
}