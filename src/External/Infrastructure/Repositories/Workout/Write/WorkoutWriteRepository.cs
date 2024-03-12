namespace Infrastructure.Repositories;

public class WorkoutWriteRepository : WriteRepository<Workout>, IWorkoutWriteRepository
{
    #region Definition & Ctor
    public WorkoutWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
