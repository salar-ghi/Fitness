namespace Infrastructure.Repositories;

public class UserReadRepository : ReadRepository<User>, IUserReadRepository
{
    #region Definition & Ctor
    public UserReadRepository(FitnessContext context) : base(context) { }

    #endregion
}
