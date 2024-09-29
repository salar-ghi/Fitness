namespace Infrastructure.Repositories;

public class BodyWorkoutRepository : Repository<BodyWorkout>, IBodyWorkoutRepository
{
    #region Definition & Ctor

    public BodyWorkoutRepository(FitnessContext context)
        : base(context)
    {
        
    }

    #endregion


}
