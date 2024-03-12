namespace Infrastructure.Repositories;

public class WorkoutEquipmentWriteRepository : WriteRepository<WorkoutEquipment>, IWorkoutEquipmentWriteRepository
{
    #region Definition & Ctor
    public WorkoutEquipmentWriteRepository(FitnessContext context) : base(context) { }

    #endregion

}
