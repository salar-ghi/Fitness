namespace Domain.Models;

public class PlanEquipments : BaseEntity<long, PlanEquipments>
{
    public Guid PlanId { get; set; }
    public int EquipmentId { get; set; }

}
