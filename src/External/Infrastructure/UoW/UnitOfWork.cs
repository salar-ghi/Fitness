namespace Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    #region Definition & Ctor
    // DataContext
    private readonly FitnessContext _context;

    // Plan
    private PlanDaysRepository _planDaysRepository;
    private PlanImgsRepository _planImgsRepository;


    // User
    private AthleteImgsRepository _athleteImgsRepository;
    private AthleteInjuriesRepository _athleteInjuriesRepository;
    private DiseaseRepository _diseaseRepository;

    //Workout
    private AgeRangeRepository _ageRangeRepository;
    private LevelRepository _levelRepository;
    private SportRepository _sportRepository;

    public UnitOfWork(FitnessContext context)
    {
        _context = context;
    }


    #endregion



    #region Implementation
    // Plan Interfaces
    public IPlanDaysRepository PlanDaysRepository
    {
        get
        { return _planDaysRepository ??= new PlanDaysRepository(_context); }
    }
    public IPlanImgsRepository PlanImgsRepository
    {
        get
        {
            return _planImgsRepository ??= new PlanImgsRepository(_context);
        }
    }



    // User Interfaces
    public IAthleteImgsRepository AthleteImgsRepository
    {
        get
        {
            return _athleteImgsRepository ??= new AthleteImgsRepository(_context);
        }
    }
    public IAthleteInjuriesRepository AthleteInjuriesRepository
    {
        get
        {
            return _athleteInjuriesRepository ??= new AthleteInjuriesRepository(_context);
        }
    }
    public IDiseaseRepository DiseaseRepository
    {
        get
        {
            return _diseaseRepository ??= new DiseaseRepository(_context);
        }
    }


    // Workout Interfaces
    public IAgeRangeRepository AgeRangeRepository
    {
        get
        {
            return _ageRangeRepository ??= new AgeRangeRepository(_context);
        }
    }

    public ILevelRepository LevelRepository
    {
        get
        {
            return _levelRepository ??= new LevelRepository(_context);
        }
    }
    public ISportRepository SportRepository
    {
        get
        {
            return _sportRepository ??= new SportRepository(_context);
        }
    }

    #endregion

    public void Commit()
    {
        throw new NotImplementedException();
    }


}
