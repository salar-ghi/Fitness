namespace Infrastructure.Repositories;

public class ExerciseReadRepository : ReadRepository<Exercise>, IExerciseReadRepository
{
    #region Definition & Ctor
    public ExerciseReadRepository(FitnessContext context) : base(context) { }

    #endregion
}
