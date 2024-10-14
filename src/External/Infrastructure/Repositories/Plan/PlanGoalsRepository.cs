namespace Infrastructure.Repositories;

public class PlanGoalsRepository : Repository<PlanGoals>, IPlanGoalsRepository
{
    #region Definition & Ctor
    public PlanGoalsRepository(FitnessContext context) : base(context) { }

    #endregion
}