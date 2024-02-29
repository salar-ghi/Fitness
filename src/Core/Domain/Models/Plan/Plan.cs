namespace Domain.Models;

public class Plan : BaseEntity<Guid>
{
    public string PlanName { get; private set; } = default!;
    public Enums.Level Level { get; set; } = default(Enums.Level);
    public Period Duration { get; set; } = default(Period);
    public int DaysCount { get; set; }








    public required Guid AthleteId { get; set; }
    //public ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();


    // MusclePriority
    // PlanDays
    // PlanImgs
    // Exercise
}
