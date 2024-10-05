﻿namespace Domain.Models;

public class Disease : BaseEntity<long, Disease>
{
    public string Name { get; set; }
    public string Description { get; set; } = default!;

    public required Guid AthleteId { get; set; }
    //public Athlete Athlete { get; set; }

}
