namespace Infrastructure.Repositories;

public class AthleteInjuriesRepository : Repository<AthleteInjuries>, IAthleteInjuriesRepository
{

    #region Ctor & Definition
    public AthleteInjuriesRepository(FitnessContext context) : base(context) { }

    #endregion
}
