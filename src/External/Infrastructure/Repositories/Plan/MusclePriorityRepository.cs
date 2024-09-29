namespace Infrastructure.Repositories;

public class MusclePriorityRepository : Repository<MusclePriority> , IMusclePriorityRepository
{
    #region Definition & Ctor
    public MusclePriorityRepository(FitnessContext context) : base(context) { }

    #endregion
}
