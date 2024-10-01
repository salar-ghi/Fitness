namespace Infrastructure.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    #region Definition & Ctor
    public UserRepository(FitnessContext context) : base(context) { }


    #endregion
}
