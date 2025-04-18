﻿namespace Domain.Models;

public class Disease : BaseEntity<long, Disease>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int? BodyId { get; set; }

    public required Guid AthleteId { get; set; }
    //public virtual Athlete Athlete { get; set; }

}
