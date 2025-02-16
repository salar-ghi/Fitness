namespace Domain.Models;

public class WorkoutAgeRange : BaseEntity<int, WorkoutAgeRange>
{

    public Age Age { get; set; } = default(Age);

    public int WorkoutId { get; set; }
    //public Workout Workout { get; set; }
}