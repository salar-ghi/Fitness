namespace Infrastructure.Repositories;

public class LevelRepository : Repository<Level>, ILevelRepository
{
    #region Ctor & Definition
    public LevelRepository(FitnessContext context) : base(context) { }

    #endregion
}
