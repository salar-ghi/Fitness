namespace Infrastructure.Repositories;

public class AgeRangeRepository : Repository<AgeRange>, IAgeRangeRepository
{
    #region Ctor & Definition
    public AgeRangeRepository(FitnessContext context) : base(context) {  }

    #endregion
}
