namespace gRPC.TaskManagement.DAL.Models;

public class Comment(string text)
    : BaseModel
{
    public string Text { get; set; } = text;

    public int TaskItemId { get; set; }
    public TaskItem? TaskItem { get; set; }

    public override bool Equals(object? obj) =>
        obj is Comment comment &&
        base.Equals(comment) &&
        Text == comment.Text;

    public override int GetHashCode() =>
        HashCode.Combine(base.GetHashCode(), Text);

    public static bool operator ==(Comment left, Comment right) =>
        Equals(left, right);

    public static bool operator !=(Comment left, Comment right) =>
        !Equals(left, right);
}