namespace Infrastructure.Repositories;

public class WorkoutEquipmentRepository : Repository<WorkoutEquipment> , IWorkoutEquipmentRepository
{
    #region Definition & Ctor
    public WorkoutEquipmentRepository(FitnessContext context) : base(context) { }

    #endregion
}
