namespace Domain.Models;

public class WorkoutInstruction : BaseEntity<int, WorkoutInstruction>
{
    public int WorkoutId { get; set; }
    public int Step { get; set; }
    public string Description { get; set; } = default!;
    public string? ImgUrl { get; set; }
    public string? VideoUrl { get; set; }
}
