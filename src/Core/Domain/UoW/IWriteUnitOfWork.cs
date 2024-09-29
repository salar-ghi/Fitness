namespace Domain.UoW;

public interface IWriteUnitOfWork : IDisposable
{

    // Plan Interfaces
    #region Plan
    IExerciseWriteRepository ExerciseWriteRepository { get; }
    IMusclePriorityWriteRepository MusclePriorityWriteRepository { get; }
    IPlanWriteRepository PlanWriteRepository { get; }


    #endregion


    // User Interfaces
    #region USer
    IAthleteWriteRepository AthleteWriteRepository { get; }
    IUserWriteRepository UserWriteRepository { get; }
    #endregion


    // Workout Interfaces
    #region Workout
    IBodyWriteRepository BodyWriteRepository { get; }
    IBodyWorkoutWriteRepository BodyWorkoutWriteRepository { get; }
    IEquipmentWriteRepository EquipmentWriteRepository { get; }
    IWorkoutEquipmentWriteRepository WorkoutEquipmentWriteRepository { get; }
    IWorkoutWriteRepository WorkoutWriteRepository { get; }

    #endregion

    Task<int> Commit();
}
