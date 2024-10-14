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
    IPlanDaysRepository PlanDaysRepository { get; }
    IPlanEquipmentRepository PlanEquipmentRepository { get; }
    IPlanGoalsRepository PlanGoalsRepository { get; }
    IPlanImgsRepository PlanImgsRepository { get; }
    #endregion


    // User Interfaces
    #region USer
    IAthleteRepository AthleteRepository { get; }
    IAthleteImgsRepository AthleteImgsRepository { get; }
    IAthleteInjuriesRepository AthleteInjuriesRepository { get; }
    IUserRepository UserRepository { get; }    

    #endregion


    // Workout Interfaces
    #region Workout    
    IBodyWorkoutRepository BodyWorkoutRepository { get; }
    IEquipmentRepository EquipmentRepository { get; }
    ISportRepository SportRepository { get; }
    IWorkoutRepository WorkoutRepository { get; }
    IWorkoutAgeRangeRepository WorkoutAgeRangeRepository { get; }
    IWorkoutEquipmentRepository WorkoutEquipmentRepository { get; }
    IWorkoutInstructionRepository WorkoutInstructionRepository { get; }
    IWorkoutLevelRepository WorkoutLevelRepository { get; }
    IWorkoutSexRepository WorkoutSexRepository { get; }

    #endregion

    Task<int> Commit();
}
