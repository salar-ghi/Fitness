namespace Domain.Models;

public class Exercise : BaseEntity<Guid, Exercise>
{
    public Guid PlanId { get; set; }
    //public ICollection<Plan> Plans { get; set; } = new List<Plan>();

    public int WorkoutId { get; set; }
    //public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
    public ExerciseType ExerciseType { get; set; }

    public int RecommendSets { get; set; }
    public int RecommendReps { get; set; }
    public float RecommendWeight { get; set; }
    public int RecommendRestTime { get; set; } // Second


    public bool IsOk { get; set; } // be nazare karbar ok hastr ke in tamrin behesh suggest shode 
                                    // dar sorate har do javab bale ye kheyr, result chie ????
    public bool Completed { get; set; } // bad az anjam, bege ke anjam dade dar jahate anlyse kardane moshtari
}
