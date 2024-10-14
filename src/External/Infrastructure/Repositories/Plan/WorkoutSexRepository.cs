namespace Infrastructure.Repositories;

public class WorkoutSexRepository : Repository<WorkoutSex>, IWorkoutSexRepository
{
    #region Ctor & Definition
    public WorkoutSexRepository(FitnessContext context) : base(context) { }

    #endregion
}
