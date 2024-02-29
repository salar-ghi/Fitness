namespace Domain.Models;

public class Exercise : BaseEntity<Guid>
{
    public Guid PlanId { get; set; }
    //public ICollection<Plan> Plans { get; set; } = new List<Plan>();

    public int WorkoutId { get; set; }
    //public ICollection<Workout> Workouts { get; set; } = new List<Workout>();


    public bool IsOk { get; set; }
    public bool Completed { get; set; }
    public int RecommendSet { get; set; }
    public int RecommendWeight { get; set; }


}
