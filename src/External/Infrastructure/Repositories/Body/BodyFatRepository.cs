namespace Infrastructure.Repositories;

public class BodyFatRepository : Repository<BodyFat>, IBodyFatRepository
{
    #region Introduction & Ctor
    public BodyFatRepository(FitnessContext context)
        : base(context)
    {

    }
    #endregion
}
