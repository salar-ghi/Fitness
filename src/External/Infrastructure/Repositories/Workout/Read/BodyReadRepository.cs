
namespace Infrastructure.Repositories;

public class BodyReadRepository : ReadRepository<Body>, IBodyReadRepository
{
    #region Introduction & Ctor
    public BodyReadRepository(FitnessContext context)
        : base(context)
    {
        
    }
    #endregion
}
