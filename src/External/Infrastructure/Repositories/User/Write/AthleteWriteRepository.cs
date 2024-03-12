namespace Infrastructure.Repositories;

public class AthleteWriteRepository : WriteRepository<Athlete>, IAthleteWriteRepository
{
    #region Definition & Ctor
    public AthleteWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
