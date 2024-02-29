namespace Domain.Models;

public class AgeRange : BaseEntity<int>
{
    public int? WorkoutId { get; private set; }
    //public required Workout Workout { get; set; } = null!;
    public Age Age { get; set; } = default(Age);
}
