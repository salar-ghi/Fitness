namespace Infrastructure.Repositories;

public class EquipmentWriteRepository : WriteRepository<Equipment>, IEquipmentWriteRepository
{
    #region Definition & Ctor
    public EquipmentWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
