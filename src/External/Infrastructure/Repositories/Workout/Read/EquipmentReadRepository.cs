namespace Infrastructure.Repositories;

public class EquipmentReadRepository : ReadRepository<Equipment>, IEquipmentReadRepository
{
    #region Definition & Ctor
    public EquipmentReadRepository(FitnessContext context) : base(context) {}

    #endregion
}
