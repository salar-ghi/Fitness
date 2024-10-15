
namespace Infrastructure.EntityTypeConfiguration;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.PlanId).IsClustered(false);
        builder.HasIndex(e => e.WorkoutId).IsClustered(false);
        builder.Property(e => e.ExerciseType).IsRequired();
        //builder.HasKey(e => e.RecommendSets);
        

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
