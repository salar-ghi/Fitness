﻿namespace Domain.Models;

public class PlanDays : BaseEntity<long, PlanDays>
{
    public DayOfWeek Day { get; set; } = default(DayOfWeek);
    public TimeSpan Hour { get; set; }
    public Guid PlanId { get; set; }

}
