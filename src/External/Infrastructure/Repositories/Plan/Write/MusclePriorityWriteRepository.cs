namespace Infrastructure.Repositories;

public class MusclePriorityWriteRepository : WriteRepository<MusclePriority>, IMusclePriorityWriteRepository
{
    #region Definition & Ctor
    public MusclePriorityWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
