namespace Infrastructure.UoW;

public class WriteUnitOfWork : IWriteUnitOfWork
{
    #region Defenition & Ctor

    private readonly FitnessContext _context;
    public WriteUnitOfWork(FitnessContext context)
    {
        _context = context;
    }


    // Plan
    private ExerciseWriteRepository _exerciseWriteRepository;
    private MusclePriorityWriteRepository _musclePriorityWriteRepository;
    private PlanWriteRepository _planWriteRepository;

    // User
    private AthleteWriteRepository _athleteWriteRepository;
    private UserWriteRepository _userWriteRepository;

    //Workout
    private BodyWorkoutWriteRepository _bodyWorkoutWriteRepository;
    private BodyWriteRepository _bodyWriteRepository;
    private EquipmentWriteRepository _equipmentWriteRepository;
    private WorkoutEquipmentWriteRepository _workoutEquipmentWriteRepository;
    private WorkoutWriteRepository _workoutWriteRepository;



    #endregion



    #region Implementation

    // Plan
    public IExerciseWriteRepository ExerciseWriteRepository
    {
        get
        {
            return _exerciseWriteRepository ??= new ExerciseWriteRepository(_context);
        }
    }
    public IMusclePriorityWriteRepository MusclePriorityWriteRepository 
    {
        get
        {
            return _musclePriorityWriteRepository ??= new MusclePriorityWriteRepository(_context);
        }
    }
    public IPlanWriteRepository PlanWriteRepository 
    {
        get
        {
            return _planWriteRepository ??= new PlanWriteRepository(_context);
        }
    }



    // User
    public IAthleteWriteRepository AthleteWriteRepository 
    {
        get
        {
            return _athleteWriteRepository ??= new AthleteWriteRepository(_context);
        }
    }
    public IUserWriteRepository UserWriteRepository 
    { 
        get
        {
            return (_userWriteRepository ??= new UserWriteRepository(_context));
        }
    }



    //Workout
    public IBodyWriteRepository BodyWriteRepository
    {
        get
        {
            return _bodyWriteRepository ??= new BodyWriteRepository(_context);
        }
    }

    public IBodyWorkoutWriteRepository BodyWorkoutWriteRepository 
    {
        get
        {
            return _bodyWorkoutWriteRepository ??= new BodyWorkoutWriteRepository(_context);
        }
    }

    public IEquipmentWriteRepository EquipmentWriteRepository 
    {
        get
        {
            //return (EquipmentWriteRepository)_equipmentWriteRepository;
            return _equipmentWriteRepository ??= new EquipmentWriteRepository(_context);
        }
    }

    public IWorkoutEquipmentWriteRepository WorkoutEquipmentWriteRepository 
    {
        get
        {
            return _workoutEquipmentWriteRepository ??= new WorkoutEquipmentWriteRepository(_context);
        }
    }

    public IWorkoutWriteRepository WorkoutWriteRepository 
    {
        get
        {
            return _workoutWriteRepository ??= new WorkoutWriteRepository(_context);
        }
    }

    #endregion

    public void Commit()
    {
        throw new NotImplementedException();
    }
}
