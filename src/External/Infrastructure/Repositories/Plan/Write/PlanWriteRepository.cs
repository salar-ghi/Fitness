namespace Infrastructure.Repositories;

public class PlanWriteRepository : WriteRepository<Plan>, IPlanWriteRepository
{
    #region Ctor & Definition
    public PlanWriteRepository(FitnessContext context) : base(context) { }
    #endregion
}
