namespace Domain.UoW;

public interface IUnitOfWork : IDisposable
{

    // Body Interfaces
    #region Body
    IBodyRepository BodyRepository { get; }
    IDiseaseRepository DiseaseRepository { get; }

    #endregion

    // Plan Interfaces
    #region Plan
    IExerciseRepository ExerciseRepository { get; }
    IMusclePriorityRepository MusclePriorityRepository { get; }
    IPlanRepository PlanRepository { get; }
    IPlanEquipmentRepository PlanEquipmentRepository { get; }
    IPlanDaysRepository PlanDaysRepository { get; }
    IPlanImgsRepository PlanImgsRepository { get; }
    #endregion


    // User Interfaces
    #region USer
    IAthleteRepository AthleteRepository { get; }
    IUserRepository UserRepository { get; }
    IAthleteImgsRepository AthleteImgsRepository { get; }
    IAthleteInjuriesRepository AthleteInjuriesRepository { get; }
    

    #endregion


    // Workout Interfaces
    #region Workout    
    IBodyWorkoutRepository BodyWorkoutRepository { get; }
    IEquipmentRepository EquipmentRepository { get; }
    IWorkoutEquipmentRepository WorkoutEquipmentRepository { get; }
    IWorkoutRepository WorkoutRepository { get; }
    IAgeRangeRepository AgeRangeRepository { get; }
    ILevelRepository LevelRepository { get; }
    ISportRepository SportRepository { get; }

    #endregion

    Task<int> Commit();
}
