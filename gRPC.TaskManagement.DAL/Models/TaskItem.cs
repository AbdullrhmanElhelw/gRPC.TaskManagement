using gRPC.TaskManagement.DAL.Enums;

namespace gRPC.TaskManagement.DAL.Models;

public class TaskItem
    (string name, string description, Status status, Priority priority)
    : BaseModel
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public Status Status { get; set; } = status;
    public Priority Priority { get; set; } = priority;

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public int ProjectId { get; set; }
    public Project? Project { get; set; }

    public ICollection<Comment> Comments { get; set; } = [];

    public override bool Equals(object? obj) => obj is TaskItem item &&
        base.Equals(item) &&
        Name == item.Name &&
        Description == item.Description &&
        Status == item.Status &&
        Priority == item.Priority;

    public override int GetHashCode() =>
        HashCode.Combine(base.GetHashCode(), Name, Description, Status, Priority);

    public static bool operator ==(TaskItem left, TaskItem right) =>
        Equals(left, right);

    public static bool operator !=(TaskItem left, TaskItem right) =>
        !Equals(left, right);
}