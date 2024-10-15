namespace Infrastructure.Context;

//: DbContext
public class FitnessContext : IdentityDbContext<User, IdentityRole<Guid>, Guid, 
        IdentityUserClaim<Guid>, IdentityUserRole<Guid>, 
        IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>> {
    //protected override void OnModelCreating(DbContextOptionsBuilder optionBuilder)    

    public FitnessContext(DbContextOptions options) : base(options) { }

    // Body DbSet
    public virtual DbSet<Body> Bodies { get; set; }
    public virtual DbSet<Disease> Diseases { get; set; }

    // Plan DbSet
    public virtual DbSet<Exercise> Exercises { get; set; }
    //public virtual DbSet<ExerciseDetail> ExerciseDetails { get; set; }
    public virtual DbSet<MusclePriority> MusclePriorities { get; set; }
    public virtual DbSet<Plan> Plans { get; set; }
    public virtual DbSet<PlanDays> PlanDays { get; set; }
    public virtual DbSet<PlanEquipments> PlanEquipments { get; set; }
    public virtual DbSet<PlanGoals> PlanGoals { get; set; }
    public virtual DbSet<PlanImgs> PlanImgs { get; set; }

    // User DbSet
    public virtual DbSet<Athlete> Athletes { get; set; }
    public virtual DbSet<AthleteImgs> AthleteImgs { get; set; }
    public virtual DbSet<AthleteInjuries> AthleteInjuries { get; set; }
    public virtual DbSet<User> Users { get; set; }
    //public virtual DbSet<UserRole> UserRoles  { get; set; }


    // Workout DbSet
    public virtual DbSet<BodyWorkout> BodyWorkouts { get; set; }
    public virtual DbSet<Equipment> Equipments { get; set; }
    public virtual DbSet<Sport> Sports { get; set; }
    public virtual DbSet<Workout> Workouts { get; set; }
    public virtual DbSet<WorkoutAgeRange> WorkoutAgeRanges { get; set; }
    public virtual DbSet<WorkoutEquipment> WorkoutEquipment { get; set; }
    public virtual DbSet<WorkoutInstruction> WorkoutInstructions { get; set; }
    public virtual DbSet<WorkoutLevel> WorkoutLevels { get; set; }
    public virtual DbSet<WorkoutSex> WorkoutSex { get; set; }


    //protected override void onConfiguration(DbContextOptionsBuilder optionsBuilder)
    //{
    ////    optionsBuilder.UseLazyLoadingProxies();
    //}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<User>().ToTable("Users");
        builder.Entity<IdentityRole>().ToTable("Roles");

        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");

        // Plan Configuration
        builder.ApplyConfiguration(new ExerciseConfiguration());
        //modelBuilder.ApplyConfiguration(new ExerciseDetailConfiguration());
        builder.ApplyConfiguration(new MusclePriorityConfiguration());
        builder.ApplyConfiguration(new PlanConfiguration());
        builder.ApplyConfiguration(new PlanDaysConfiguration());
        builder.ApplyConfiguration(new PlanImgsConfiguration());

        // User Configuration
        builder.ApplyConfiguration(new AthleteConfiguration());
        builder.ApplyConfiguration(new AthleteImgsConfiguration());
        builder.ApplyConfiguration(new AthleteImgsConfiguration());
        builder.ApplyConfiguration(new DiseaseConfiguration());
        builder.ApplyConfiguration(new UserConfiguration());
        //modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

        // Workout Configuration
        builder.ApplyConfiguration(new WorkoutAgeRangeConfiguration());
        builder.ApplyConfiguration(new BodyConfiguration());
        builder.ApplyConfiguration(new BodyWorkoutConfiguration());
        builder.ApplyConfiguration(new EquipmentConfiguration());
        builder.ApplyConfiguration(new WorkoutLevelConfiguration());
        builder.ApplyConfiguration(new SportConfiguration());
        builder.ApplyConfiguration(new WorkoutConfiguration());
        builder.ApplyConfiguration(new WorkoutEquipmentConfiguration());


        builder.Entity<Workout>().HasData(
            new Workout { Id = 1, Name = "", SportId = 1, Description = ""}
            );

        builder.Entity<WorkoutLevel>().HasData(
            new WorkoutLevel { WorkoutId = 1, Level = Domain.Enums.Level.Beginner, Description = "" }
            );
    }
}
