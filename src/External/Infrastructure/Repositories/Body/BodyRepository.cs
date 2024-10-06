namespace Infrastructure.Repositories;

public class BodyRepository : Repository<Body>, IBodyRepository
{
    #region Introduction & Ctor
    public BodyRepository(FitnessContext context)
        : base(context)
    {
        
    }
    #endregion
}
