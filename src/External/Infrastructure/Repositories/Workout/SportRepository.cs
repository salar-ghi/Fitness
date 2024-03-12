namespace Infrastructure.Repositories;

public class SportRepository : Repository<Sport>, ISportRepository
{
    #region Ctor & Definition
    public SportRepository(FitnessContext context) : base(context) { }

    #endregion
}
