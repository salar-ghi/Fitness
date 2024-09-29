namespace Infrastructure.Repositories;

public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
{
    #region Definition & Ctor
    public ExerciseRepository(FitnessContext context) : base(context) { }

    #endregion
}
