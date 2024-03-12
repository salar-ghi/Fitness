namespace Infrastructure.Repositories;

public class PlanDaysRepository : Repository<PlanDays>, IPlanDaysRepository
{
    #region Ctor & Definition
    public PlanDaysRepository(FitnessContext context) : base(context) { }

    #endregion
}
