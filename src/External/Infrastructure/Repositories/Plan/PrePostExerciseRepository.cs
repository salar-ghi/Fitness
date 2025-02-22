namespace Infrastructure.Repositories;

public class PrePostExerciseRepository : Repository<PrePostExercise>, IPrePostExerciseRepository
{
    #region Definition & Ctor
    public PrePostExerciseRepository(FitnessContext context) : base(context) { }

    #endregion
}

