namespace Infrastructure.Repositories;

public class ExerciseWriteRepository : WriteRepository<Exercise>, IExerciseWriteRepository
{
    #region Definition & Ctor
    public ExerciseWriteRepository(FitnessContext context) : base(context) { }

    #endregion
}
