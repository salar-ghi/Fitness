namespace Domain.Models;

public class PrePostExercise : BaseEntity<Guid, PrePostExercise>
{
    public Guid PlanId { get; set; }
    public int WorkoutId { get; set; }
    public PrePostExerciseType PrePostExerciseType { get; set; }

    public int RecommendSets { get; set; }
    public int RecommendReps { get; set; }
    public float RecommendWeight { get; set; }
}
