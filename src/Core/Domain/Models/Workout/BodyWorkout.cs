namespace Domain.Models;

public class BodyWorkout : BaseEntity<int, BodyWorkout>
{
    public required int BodyId { get; set; } 
    //public required Body Body { get; set; } = null!;
    public required int WorkoutId { get; set; }
    //public required Workout Workout { get; set; } = null!;
}
