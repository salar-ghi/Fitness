
namespace Infrastructure.EntityTypeConfiguration;

public class ExerciseDetailConfiguration : IEntityTypeConfiguration<ExerciseDetail>
{
    public void Configure(EntityTypeBuilder<ExerciseDetail> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
