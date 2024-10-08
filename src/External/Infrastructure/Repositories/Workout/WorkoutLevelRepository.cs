namespace Infrastructure.Repositories;

public class WorkoutLevelRepository : Repository<WorkoutLevel>, IWorkoutLevelRepository
{
    #region Ctor & Definition
    public WorkoutLevelRepository(FitnessContext context) : base(context) { }

    #endregion
}
