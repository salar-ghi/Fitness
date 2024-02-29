namespace Domain.Models;

public class Level: BaseEntity<int>
{
    public Enums.Level Name { get; set; }
    public string Description { get; private set; } = default!;

    public required int WorkoutId { get; set; }
    //public required Workout Workout { get; set; } = null!;
}
