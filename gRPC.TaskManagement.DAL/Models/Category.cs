using gRPC.TaskManagement.DAL.Enums;

namespace gRPC.TaskManagement.DAL.Models;

public class Category
    (string name, string description, TaskColor color)
    : BaseModel
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public TaskColor Color { get; set; } = color;

    public ICollection<TaskItem> Tasks { get; set; } = [];

    public override bool Equals(object? obj) => obj is Category category &&
        base.Equals(category) &&
        Name == category.Name &&
        Description == category.Description &&
        Color == category.Color;

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Id, CreatedAt, UpdatedAt, IsDeleted, Name, Description, Color);
    }

    public static bool operator ==(Category? left, Category? right)
    {
        return EqualityComparer<Category>.Default.Equals(left, right);
    }

    public static bool operator !=(Category? left, Category? right)
    {
        return !(left == right);
    }
}