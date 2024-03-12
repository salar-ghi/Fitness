namespace Infrastructure.Repositories;

public class UserWriteRepository : WriteRepository<User> , IUserWriteRepository
{
    #region Definition & Ctor
    public UserWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
