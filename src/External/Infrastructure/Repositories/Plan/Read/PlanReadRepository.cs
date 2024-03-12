namespace Infrastructure.Repositories;

public class PlanReadRepository : ReadRepository<Plan> , IPlanReadRepository
{
    #region Definition & Ctor
    public PlanReadRepository(FitnessContext context) : base(context) { }

    #endregion
}
