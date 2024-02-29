
namespace Infrastructure.EntityTypeConfiguration;

public class BodyWorkoutConfiguration : IEntityTypeConfiguration<BodyWorkout>
{
    public void Configure(EntityTypeBuilder<BodyWorkout> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.BodyId).IsRequired();
        builder.Property(e => e.WorkoutId).IsRequired();

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
