namespace gRPC.TaskManagement.DAL.Models;

public class BaseModel
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is BaseModel model &&
               Id == model.Id &&
               CreatedAt == model.CreatedAt &&
               UpdatedAt == model.UpdatedAt &&
               IsDeleted == model.IsDeleted;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, CreatedAt, UpdatedAt, IsDeleted);
    }
}