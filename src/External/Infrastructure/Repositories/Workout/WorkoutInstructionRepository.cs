namespace Infrastructure.Repositories;

public class WorkoutInstructionRepository : Repository<WorkoutInstruction>, IWorkoutInstructionRepository
{
    #region Ctor & Definition
    public WorkoutInstructionRepository(FitnessContext context) : base(context) { }

    #endregion
}
