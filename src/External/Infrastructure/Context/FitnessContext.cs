namespace Infrastructure.Context;

public class FitnessContext : DbContext
{
    //protected override void OnModelCreating(DbContextOptionsBuilder optionBuilder)
    

    public FitnessContext(DbContextOptions options) : base(options)
    { 
    }

    // Plan DbSet
    public virtual DbSet<Exercise> Exercises { get; set; }
    //public virtual DbSet<ExerciseDetail> ExerciseDetails { get; set; }
    public virtual DbSet<MusclePriority> MusclePriorities { get; set; }
    public virtual DbSet<Plan> Plans { get; set; }
    public virtual DbSet<PlanDays> PlanDays { get; set; }
    public virtual DbSet<PlanImgs> PlanImgs { get; set; }



    // User DbSet
    public virtual DbSet<Athlete> Athletes { get; set; }
    public virtual DbSet<AthleteImgs> AthleteImgs { get; set; }
    public virtual DbSet<AthleteInjuries> AthleteInjuries { get; set; }
    public virtual DbSet<Disease> Diseases { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserRole> UserRoles  { get; set; }


    // Workout DbSet
    public virtual DbSet<AgeRange> AgeRanges { get; set; }
    public virtual DbSet<Body> Bodies { get; set; }
    public virtual DbSet<BodyWorkout> BodyWorkouts { get; set; }
    public virtual DbSet<Equipment> Equipment { get; set; }
    public virtual DbSet<Level> Levels { get; set; }
    public virtual DbSet<Sport> Sports { get; set; }
    public virtual DbSet<Workout> Workouts { get; set; }
    public virtual DbSet<WorkoutEquipment> WorkoutEquipment { get; set; }


    //protected override void onConfiguration(DbContextOptionsBuilder optionsBuilder)
    //{
    ////    optionsBuilder.UseLazyLoadingProxies();
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        

        // Plan Configuration
        modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
        //modelBuilder.ApplyConfiguration(new ExerciseDetailConfiguration());
        modelBuilder.ApplyConfiguration(new MusclePriorityConfiguration());
        modelBuilder.ApplyConfiguration(new PlanConfiguration());
        modelBuilder.ApplyConfiguration(new PlanDaysConfiguration());
        modelBuilder.ApplyConfiguration(new PlanImgsConfiguration());

        // User Configuration
        modelBuilder.ApplyConfiguration(new AthleteConfiguration());
        modelBuilder.ApplyConfiguration(new AthleteImgsConfiguration());
        modelBuilder.ApplyConfiguration(new AthleteImgsConfiguration());
        modelBuilder.ApplyConfiguration(new DiseaseConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        //modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

        // Workout Configuration
        modelBuilder.ApplyConfiguration(new AgeRangeConfiguration());
        modelBuilder.ApplyConfiguration(new BodyConfiguration());
        modelBuilder.ApplyConfiguration(new BodyWorkoutConfiguration());
        modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
        modelBuilder.ApplyConfiguration(new LevelConfiguration());
        modelBuilder.ApplyConfiguration(new SportConfiguration());
        modelBuilder.ApplyConfiguration(new WorkoutConfiguration());
        modelBuilder.ApplyConfiguration(new WorkoutEquipmentConfiguration());
    }
}
