namespace Infrastructure.Repositories;

public class PlanImgsRepository : Repository<PlanImgs>, IPlanImgsRepository
{
    #region Ctor & Definition
    public PlanImgsRepository(FitnessContext context) : base(context) { }

    #endregion
}
