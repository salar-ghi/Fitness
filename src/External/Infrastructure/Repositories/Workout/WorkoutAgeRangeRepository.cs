namespace Infrastructure.Repositories;

public class WorkoutAgeRangeRepository : Repository<WorkoutAgeRange>, IWorkoutAgeRangeRepository
{
    #region Ctor & Definition
    public WorkoutAgeRangeRepository(FitnessContext context) : base(context) {  }

    #endregion
}
