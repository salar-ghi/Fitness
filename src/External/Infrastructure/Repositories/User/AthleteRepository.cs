namespace Infrastructure.Repositories;

public class AthleteRepository : Repository<Athlete>,IAthleteRepository
{
    #region Definition & Ctor
    public AthleteRepository(FitnessContext context) : base(context) { }

    #endregion
}
