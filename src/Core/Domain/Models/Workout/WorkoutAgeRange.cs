namespace Domain.Models;

public class WorkoutAgeRange : BaseEntity<int, WorkoutAgeRange>
{
    public Workout Workout { get; set; }
    public int WorkoutId { get; set; }

    public Age Age { get; set; } = default(Age);

}