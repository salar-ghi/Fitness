namespace Infrastructure.Repositories;

public class BodyWorkoutWriteRepository : WriteRepository<BodyWorkout> , IBodyWorkoutWriteRepository
{
    #region Definition & Ctor
    public BodyWorkoutWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
