namespace Domain.Models;

public class WorkoutInstruction : BaseEntity<int, WorkoutInstruction>
{
    public int Step { get; set; }
    public string Instruction { get; set; } = default!;
    public string? ImgUrl { get; set; }
    public string? VideoUrl { get; set; }
    public int WorkoutId { get; set; }
    //[ForeignKey(nameof(Workout))]
    //public virtual Workout Workout { get; set; }
}
