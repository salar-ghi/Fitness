namespace Infrastructure.Context;

public class FitnessContext : DbContext
{
    //protected override void OnModelCreating(DbContextOptionsBuilder optionBuilder)

    public virtual DbSet<Workout> Workouts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new );
    }
}
