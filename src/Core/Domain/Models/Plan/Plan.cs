namespace Domain.Models;

public class Plan : BaseEntity<Guid, Plan>
{
    public string PlanName { get; set; } = default!;
    public Enums.Level Level { get; set; } = default(Enums.Level);
    public Period Duration { get; set; } = default(Period);
    public int DaysCount { get; set; }
    public int AthleteOverWeight { get; set; } // in bayad bere to ye jadvale joda ,
                                               // va dataye har varzeshkar dar hengame shoro va payan onja sabt beshe 







    public required Guid AthleteId { get; set; }
    //public ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();


    // !!!!!!!!!!!!!!!!!!!!!!!! Very important parts !!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // PlanEquipment
    // MusclePriority
    // PlanDays
    // PlanImgs // in yeki az hamon jadavele ke teye dore data ro jam mikone
    // Exercise
}
