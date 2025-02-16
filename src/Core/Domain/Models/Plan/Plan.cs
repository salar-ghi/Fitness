namespace Domain.Models;

public class Plan : BaseEntity<Guid, Plan>
{
    public string PlanCode { get; set; } = default!;
    public Difficulty Level { get; set; } = default(Difficulty);
    public Period Duration { get; set; } = default(Period);
    public int DaysCount { get; set; }

    // *********************
    // yek jadval ham bayad ijad beshe mabni bar inke hadafe plan varzeshi be soraate
    // vazni, hajmi, azole, va mabaghi chizha behesh qofte beshe.

    // ***************
    // Custom Exercises:
    // yek jadvale dg bayad ijad beshe va be karbar ejaze bede
    // ke ya harkati ro hazf kone ya yek harkat ro ezafe bokone.

    // ***************
    // Progress Tracking
    // Implement a Table to track progress over time, including: Max weight lifted / Max repetitions / Volume(total weight x reps)


    public required Guid AthleteId { get; set; }
    //public ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();


    // !!!!!!!!!!!!!!!!!!!!!!!! Very important parts !!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // PlanGoals
    // PlanEquipments
    // MusclePriority
    // PlanDays
    // PlanImgs // in yeki az hamon jadavele ke teye dore data ro jam mikone
    // Exercise
}
