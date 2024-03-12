namespace Infrastructure.Repositories;

public class BodyWorkoutReadRepository : ReadRepository<BodyWorkout>, IBodyWorkoutReadRepository
{
    #region Definition & Ctor

    public BodyWorkoutReadRepository(FitnessContext context)
        : base(context)
    {
        
    }

    #endregion


}
