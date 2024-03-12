namespace Infrastructure.Repositories;

public class MusclePriorityReadRepository : ReadRepository<MusclePriority> , IMusclePriorityReadRepository
{
    #region Definition & Ctor
    public MusclePriorityReadRepository(FitnessContext context) : base(context) { }

    #endregion
}
