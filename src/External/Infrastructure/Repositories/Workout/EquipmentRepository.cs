namespace Infrastructure.Repositories;

public class EquipmentRepository : Repository<Equipment>, IEquipmentRepository
{
    #region Definition & Ctor
    public EquipmentRepository(FitnessContext context) : base(context) {}

    #endregion
}
