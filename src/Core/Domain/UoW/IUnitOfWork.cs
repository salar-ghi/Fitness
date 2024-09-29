namespace Domain.UoW;

public interface IUnitOfWork : IDisposable
{
    // Plan Interfaces
    #region Plan
    IPlanDaysRepository PlanDaysRepository { get; }
    IPlanImgsRepository PlanImgsRepository { get; }
    #endregion


    // User Interfaces
    #region USer
    IAthleteImgsRepository AthleteImgsRepository { get; }
    IAthleteInjuriesRepository AthleteInjuriesRepository { get; }
    IDiseaseRepository DiseaseRepository { get; }

    #endregion


    // Workout Interfaces
    #region Workout
    IAgeRangeRepository AgeRangeRepository { get; }
    ILevelRepository LevelRepository { get; }
    ISportRepository SportRepository { get; }

    #endregion

    Task<int> Commit();
}
