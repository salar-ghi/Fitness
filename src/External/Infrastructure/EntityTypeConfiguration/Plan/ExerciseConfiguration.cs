
namespace Infrastructure.EntityTypeConfiguration;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.PlanId).IsRequired();
        builder.Property(e => e.WorkoutId).IsRequired();
        

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
