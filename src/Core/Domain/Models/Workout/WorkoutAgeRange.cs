namespace Domain.Models;

public class WorkoutAgeRange
{
    public int WorkoutId { get; set; }
    public Age Age { get; set; } = default(Age);

}