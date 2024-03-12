namespace Infrastructure.UoW;

public class ReadUnitOfWork : IReadUnitOfWork
{
    #region Introduction

    // DataContext
    private readonly FitnessContext _context;

    // Plan
    private ExerciseReadRepository _exerciseReadRepository;
    private MusclePriorityReadRepository _musclePriorityReadRepository;
    private PlanReadRepository _planReadRepository;

    // User
    private AthleteReadRepository _athleteReadRepository;
    private UserReadRepository _userReadRepository;

    //Workout
    private BodyWorkoutReadRepository _bodyWorkoutReadRepository;
    private BodyReadRepository _bodyReadRepository;
    private EquipmentReadRepository _equipmentReadRepository;
    private WorkoutEquipmentReadRepository _workoutEquipmentReadRepository;
    private WorkoutReadRepository _workoutReadRepository;

    public ReadUnitOfWork(FitnessContext context)
    {
        _context = context;
    }



    #endregion

    // Plan Repositories
    #region Plan
    public IExerciseReadRepository ExerciseReadRepository
    {
        get
        {
            return _exerciseReadRepository ??= new ExerciseReadRepository(_context);
        }
    }

    public IMusclePriorityReadRepository MusclePriorityReadRepository
    {
        get
        {
            return _musclePriorityReadRepository ??= new MusclePriorityReadRepository(_context);
        }
    }

    public IPlanReadRepository PlanReadRepository
    {
        get
        {
            return _planReadRepository ??= new PlanReadRepository(_context);
        }
    }

    #endregion



    // User Repositories
    #region User
    public IAthleteReadRepository AthleteReadRepository
    {
        get
        {
            return _athleteReadRepository ??= new AthleteReadRepository(_context);
        }
    }

    public IUserReadRepository UserReadRepository
    {
        get
        {
            return _userReadRepository ??= new UserReadRepository(_context);
        }
    }

    #endregion



    // Workout Repositories
    #region Workout
    public IBodyReadRepository BodyReadRepository
    {
        get
        {
            return _bodyReadRepository ??= new BodyReadRepository(_context);
        }
    }

    public IBodyWorkoutReadRepository BodyWorkoutReadRepository
    {
        get
        {
            return _bodyWorkoutReadRepository ??= new BodyWorkoutReadRepository(_context);
        }
    }

    public IEquipmentReadRepository EquipmentReadRepository
    {
        get
        {
            return _equipmentReadRepository ??= new EquipmentReadRepository(_context);
        }
    }

    public IWorkoutEquipmentReadRepository WorkoutEquipmentReadRepository
    {
        get
        {
            return _workoutEquipmentReadRepository ??= new WorkoutEquipmentReadRepository(_context);
        }
    }

    public IWorkoutReadRepository WorkoutReadRepository
    {
        get
        {
            return _workoutReadRepository ??= new WorkoutReadRepository(_context);
        }
    }


    #endregion

    public void Dispose()
    {
        _context.Dispose();
    }


}
