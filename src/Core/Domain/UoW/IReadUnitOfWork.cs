namespace Domain.UoW;

public interface IReadUnitOfWork : IDisposable
{
    // Plan Interfaces
    #region Plan
    IExerciseReadRepository ExerciseReadRepository { get; }
    IMusclePriorityReadRepository MusclePriorityReadRepository { get; }
    IPlanReadRepository PlanReadRepository { get; }


    #endregion


    // User Interfaces
    #region USer
    IAthleteReadRepository AthleteReadRepository { get; }
    IUserReadRepository UserReadRepository { get; }
    #endregion


    // Workout Interfaces
    #region Workout
    IBodyReadRepository BodyReadRepository {  get; }
    IBodyWorkoutReadRepository BodyWorkoutReadRepository { get; }
    IEquipmentReadRepository EquipmentReadRepository { get; }
    IWorkoutEquipmentReadRepository WorkoutEquipmentReadRepository { get; }
    IWorkoutReadRepository WorkoutReadRepository { get; }

    #endregion

}
