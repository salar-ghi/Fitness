namespace Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    #region Definition & Ctor
    // DataContext
    private readonly FitnessContext _context;

    // Body
    private BodyRepository _bodyRepository;
    private DiseaseRepository _diseaseRepository;
    private BodyFatRepository _bodyFatRepository;

    // Plan
    private ExerciseRepository _exerciseRepository;
    private MusclePriorityRepository _musclePriorityRepository;
    private PlanRepository _planRepository;
    private PlanDaysRepository _planDaysRepository;
    private PlanEquipmentRepository _planEquipmentRepository;
    private PlanGoalsRepository _planGoalsRepository;
    private PlanImgsRepository _planImgsRepository;
    private PrePostExerciseRepository _prePostExerciseRepository;

    // User
    private AthleteRepository _athleteRepository;
    private AthleteImgsRepository _athleteImgsRepository;
    private AthleteInjuriesRepository _athleteInjuriesRepository;
    private UserRepository _userRepository;

    //Workout
    private BodyWorkoutRepository _bodyWorkoutRepository;
    private EquipmentRepository _equipmentRepository;
    private SportRepository _sportRepository;
    private WorkoutRepository _workoutRepository;
    private WorkoutAgeRangeRepository _workoutAgeRangeRepository;
    private WorkoutEquipmentRepository _workoutEquipmentRepository;
    private WorkoutInstructionRepository _workoutInstructionRepository;
    private WorkoutLevelRepository _workoutLevelRepository;
    private WorkoutSexRepository _workoutSexRepository;

    public UnitOfWork(FitnessContext context)
    {
        _context = context;
    }


    #endregion



    #region Implementation


    // Body Interfaces
    public IBodyRepository BodyRepository => _bodyRepository ??=  new BodyRepository(_context);
    public IDiseaseRepository DiseaseRepository => new DiseaseRepository(_context);
    public IBodyFatRepository BodyFatRepository => new BodyFatRepository(_context);

    // Plan Interfaces
    public IExerciseRepository ExerciseRepository
    {
        get
        {
            return _exerciseRepository ??= new ExerciseRepository(_context);
        }
    }

    public IMusclePriorityRepository MusclePriorityRepository => new MusclePriorityRepository(_context);

    public IPlanRepository PlanRepository => new PlanRepository(_context);
    public IPlanDaysRepository PlanDaysRepository => new PlanDaysRepository(_context);
    public IPlanEquipmentRepository PlanEquipmentRepository => new PlanEquipmentRepository(_context);
    public IPlanGoalsRepository PlanGoalsRepository => new PlanGoalsRepository(_context);
    public IPlanImgsRepository PlanImgsRepository => new PlanImgsRepository(_context);
    public IPrePostExerciseRepository PrePostExerciseRepository => new PrePostExerciseRepository(_context);



    // User Interfaces
    public IAthleteRepository AthleteRepository => new AthleteRepository(_context);
    public IUserRepository UserRepository => new UserRepository(_context);
    public IAthleteImgsRepository AthleteImgsRepository => new AthleteImgsRepository(_context);
    public IAthleteInjuriesRepository AthleteInjuriesRepository => new AthleteInjuriesRepository(_context);


    // Workout Interfaces
    public IBodyWorkoutRepository BodyWorkoutRepository => new BodyWorkoutRepository(_context);
    public IEquipmentRepository EquipmentRepository => new EquipmentRepository(_context);
    public ISportRepository SportRepository => new SportRepository(_context);
    public IWorkoutRepository WorkoutRepository => _workoutRepository ??= new WorkoutRepository(_context);
    public IWorkoutAgeRangeRepository WorkoutAgeRangeRepository => new WorkoutAgeRangeRepository(_context);
    public IWorkoutEquipmentRepository WorkoutEquipmentRepository => new WorkoutEquipmentRepository(_context);
    public IWorkoutInstructionRepository WorkoutInstructionRepository => new WorkoutInstructionRepository(_context);
    public IWorkoutLevelRepository WorkoutLevelRepository => new WorkoutLevelRepository(_context);
    public IWorkoutSexRepository WorkoutSexRepository => new WorkoutSexRepository(_context);


    #endregion

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    public async Task<int> Commit() => await _context.SaveChangesAsync();
    public void Dispose() => _context.Dispose();


}
