using Domain.IRepositories;
using Infrastructure.Repositories;

namespace Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    #region Definition & Ctor
    // DataContext
    private readonly FitnessContext _context;

    // Plan
    private ExerciseRepository _exerciseRepository;
    private MusclePriorityRepository _musclePriorityRepository;
    private PlanRepository _planRepository;
    private PlanDaysRepository _planDaysRepository;
    private PlanImgsRepository _planImgsRepository;


    // User
    private AthleteRepository _athleteRepository;
    private UserRepository _userRepository;
    private AthleteImgsRepository _athleteImgsRepository;
    private AthleteInjuriesRepository _athleteInjuriesRepository;
    private DiseaseRepository _diseaseRepository;

    //Workout
    private BodyWorkoutRepository _bodyWorkoutRepository;
    private BodyRepository _bodyRepository;
    private EquipmentRepository _equipmentRepository;
    private WorkoutEquipmentRepository _workoutEquipmentRepository;
    private WorkoutRepository _workoutRepository;

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

    public IExerciseRepository ExerciseRepository
    {
        get
        {
            return _exerciseRepository ??= new ExerciseRepository(_context);
        }
    }

    public IMusclePriorityRepository MusclePriorityRepository => new MusclePriorityRepository(_context);

    public IPlanRepository PlanRepository => new PlanRepository(_context);
    //{ get { return _planReadRepository ??= new PlanReadRepository(_context); } }
    public IPlanDaysRepository PlanDaysRepository => new PlanDaysRepository(_context);

    public IPlanImgsRepository PlanImgsRepository => new PlanImgsRepository(_context);



    // User Interfaces
    public IAthleteRepository AthleteRepository => new AthleteRepository(_context);
    public IUserRepository UserRepository => new UserRepository(_context);


    public IAthleteImgsRepository AthleteImgsRepository => new AthleteImgsRepository(_context);

    public IAthleteInjuriesRepository AthleteInjuriesRepository => new AthleteInjuriesRepository(_context);

    public IDiseaseRepository DiseaseRepository => new DiseaseRepository(_context);


    // Workout Interfaces
    public IBodyRepository BodyRepository => new BodyRepository(_context);
    public IBodyWorkoutRepository BodyWorkoutRepository => new BodyWorkoutRepository(_context);
    public IEquipmentRepository EquipmentRepository => new EquipmentRepository(_context);
    public IWorkoutEquipmentRepository WorkoutEquipmentRepository => new WorkoutEquipmentRepository(_context);
    public IWorkoutRepository WorkoutRepository => new WorkoutRepository(_context);




    public IAgeRangeRepository AgeRangeRepository => new AgeRangeRepository(_context);

    public ILevelRepository LevelRepository => new LevelRepository(_context);

    public ISportRepository SportRepository => new SportRepository(_context);


    #endregion

    public async Task<int> Commit() => await _context.SaveChangesAsync();

    public void Dispose() => _context.Dispose();


}
