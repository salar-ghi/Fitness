namespace Domain.Models;

public class PlanEquipment : BaseEntity<long, PlanEquipment>
{
    public Guid PlanId { get; set; }
    public int EquipmentId { get; set; }

}
