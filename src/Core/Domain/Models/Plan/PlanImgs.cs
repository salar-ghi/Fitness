﻿namespace Domain.Models;

public class PlanImgs : BaseEntity<long, PlanImgs>
{
    public Guid PlanId { get; set; }
    //public ICollection<Plan> Plans { get; set; } = new List<Plan>();
    public required string ImgUrl { get; set; } = default!;


}
