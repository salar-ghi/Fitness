namespace Infrastructure.Repositories;

public class AthleteImgsRepository : Repository<AthleteImgs> , IAthleteImgsRepository
{
    #region Ctor & Definition
    public AthleteImgsRepository(FitnessContext context) : base(context) { }

    #endregion
}
