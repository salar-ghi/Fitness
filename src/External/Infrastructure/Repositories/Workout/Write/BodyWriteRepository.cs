namespace Infrastructure.Repositories;

public class BodyWriteRepository : WriteRepository<Body> , IBodyWriteRepository
{
    public BodyWriteRepository(FitnessContext context) : base(context)
    {
    }
}
