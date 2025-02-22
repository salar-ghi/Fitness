namespace Infrastructure.EntityTypeConfiguration;

public class BodyWorkoutConfiguration : IEntityTypeConfiguration<BodyWorkout>
{
    public void Configure(EntityTypeBuilder<BodyWorkout> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.HasIndex(e => new { e.BodyId , e.WorkoutId}).IsClustered(false);

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
