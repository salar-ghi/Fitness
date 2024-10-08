﻿namespace Domain.Models;

public class Plan : BaseEntity<Guid, Plan>
{
    public string PlanName { get; private set; } = default!;
    public Enums.Level Level { get; set; } = default(Enums.Level);
    public Period Duration { get; set; } = default(Period);
    public int DaysCount { get; set; }
    public int AthleteOverWeight { get; set; }







    public required Guid AthleteId { get; set; }
    //public ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();


    // !!!!!!!!!!!!!!!!!!!!!!!! Very important parts !!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // MusclePriority
    // PlanDays
    // PlanImgs
    // Exercise
}
