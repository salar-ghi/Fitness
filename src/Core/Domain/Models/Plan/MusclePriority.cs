namespace Domain.Models;

public class MusclePriority : BaseEntity<long, MusclePriority>
{
    public Guid PlanId { get; set; }
    //public ICollection<Plan> Plans { get; set; } = new List<Plan>();
    public int BodyId { get; set; }
    //public ICollection<Body> Bodies { get; set; } = new List<Body>();
}
