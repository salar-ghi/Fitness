namespace Infrastructure.Repositories;

public class PlanEquipmentRepository : Repository<PlanEquipment>, IPlanEquipmentRepository
{
    #region Definition & Ctor
    public PlanEquipmentRepository(FitnessContext context) : base(context) { }

    #endregion
}
