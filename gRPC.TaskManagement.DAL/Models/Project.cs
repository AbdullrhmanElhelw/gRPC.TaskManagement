namespace gRPC.TaskManagement.DAL.Models;

public class Project
        (string name, string description, DateTime startDate, DateTime endDate)
        : BaseModel
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;

    public ICollection<TaskItem> Tasks { get; set; } = [];

    public override bool Equals(object? obj) =>
        obj is Project project &&
        base.Equals(obj) &&
        Name == project.Name &&
        Description == project.Description &&
        StartDate == project.StartDate &&
        EndDate == project.EndDate;

    public override int GetHashCode() =>
        HashCode.Combine(base.GetHashCode(), Name, Description, StartDate, EndDate);

    public static bool operator ==(Project left, Project right) =>
        Equals(left, right);

    public static bool operator !=(Project left, Project right) =>
        !Equals(left, right);
}