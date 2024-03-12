namespace Infrastructure.Repositories;

public class WorkoutReadRepository : ReadRepository<Workout>, IWorkoutReadRepository
{
    #region Definition & Ctor
    public WorkoutReadRepository(FitnessContext context) : base(context) { }

    #endregion
}
