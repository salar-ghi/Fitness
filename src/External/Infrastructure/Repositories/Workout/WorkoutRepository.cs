namespace Infrastructure.Repositories;

public class WorkoutRepository : Repository<Workout>, IWorkoutRepository
{
    #region Definition & Ctor
    public WorkoutRepository(FitnessContext context) : base(context) { }

    #endregion
}
