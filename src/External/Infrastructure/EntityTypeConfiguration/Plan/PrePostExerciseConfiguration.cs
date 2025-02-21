
namespace Infrastructure.EntityTypeConfiguration;

public class PrePostExerciseConfiguration : IEntityTypeConfiguration<PrePostExercise>
{
    public void Configure(EntityTypeBuilder<PrePostExercise> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.PlanId).IsClustered(false);
        builder.HasIndex(e => e.WorkoutId).IsClustered(false);
    }
}
