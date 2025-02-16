namespace Domain.Models;

public class WorkoutLevel : BaseEntity<int, WorkoutLevel>
{

    public Difficulty Level { get; set; }
    public string Description { get; set; } = default!;
    public int WorkoutId { get; set; }
    //public Workout Workout { get; set; } = null!;

}
