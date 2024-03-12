namespace Infrastructure.Repositories;

public class WorkoutEquipmentReadRepository  :ReadRepository<WorkoutEquipment> , IWorkoutEquipmentReadRepository
{
    #region Definition & Ctor
    public WorkoutEquipmentReadRepository(FitnessContext context) : base(context) { }

    #endregion

}
