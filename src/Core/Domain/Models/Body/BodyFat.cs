namespace Domain.Models;

public class BodyFat : BaseEntity<int, BodyFat>
{
    public int bodyId { get; set; }
    public Guid PlanId { get; set; }
    public int Percent { get; set; }
}
