namespace Domain.Models;

public class WorkoutSex : BaseEntity<int, WorkoutSex>
{
    public int WorkoutId { get; set; }
    public Workout Workout { get; set; } = null!;

    public Sex Sex { get; set; }
}
