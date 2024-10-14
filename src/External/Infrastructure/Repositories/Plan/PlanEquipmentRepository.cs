namespace Infrastructure.Repositories;

public class PlanEquipmentRepository : Repository<PlanEquipments>, IPlanEquipmentRepository
{
    #region Definition & Ctor
    public PlanEquipmentRepository(FitnessContext context) : base(context) { }

    #endregion
}
