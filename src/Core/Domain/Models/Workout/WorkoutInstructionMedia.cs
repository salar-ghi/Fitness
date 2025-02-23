namespace Domain.Models;

public class WorkoutInstructionMedia : BaseEntity<int, WorkoutInstructionMedia>
{
    public int Step { get; set; }
    public MediaType MediaType { get; set; }
    public string MediaUrl { get; set; } = default!;
    public int WorkoutId { get; set; }
    //[ForeignKey(nameof(Workout))]
    //public virtual Workout Workout { get; set; }
}
