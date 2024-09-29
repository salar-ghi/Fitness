namespace Infrastructure.Repositories;

public class PlanRepository : Repository<Plan> , IPlanRepository
{
    #region Definition & Ctor
    public PlanRepository(FitnessContext context) : base(context) { }

    #endregion
}
