namespace Domain.Models;

public class BodyWorkout : BaseEntity<int, BodyWorkout>
{
    public int BodyId { get; set; }
    public Body Body { get; set; } = null!;
    public int WorkoutId { get; set; }
    public Workout Workout { get; set; } = null!;

    public PriorityTarget Target { get; set; }
}
