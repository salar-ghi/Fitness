namespace Infrastructure.Repositories;

public class AthleteReadRepository : ReadRepository<Athlete>,IAthleteReadRepository
{
    #region Definition & Ctor
    public AthleteReadRepository(FitnessContext context) : base(context) { }

    #endregion
}
