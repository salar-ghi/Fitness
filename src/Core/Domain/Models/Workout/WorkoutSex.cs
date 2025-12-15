namespace Domain.Models;

public class WorkoutSex : BaseEntity<int, WorkoutSex>
{
    public int WorkoutId { get; set; }
    public virtual Workout Workout { get; set; } = null!;
    public Sex Sex { get; set; }
}
