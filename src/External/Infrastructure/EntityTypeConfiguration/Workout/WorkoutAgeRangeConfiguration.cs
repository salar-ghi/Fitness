namespace Infrastructure.EntityTypeConfiguration;


public class WorkoutAgeRangeConfiguration : IEntityTypeConfiguration<WorkoutAgeRange>
{
    public void Configure(EntityTypeBuilder<WorkoutAgeRange> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.WorkoutId).IsRequired();
        builder.Property(e => e.Age).IsRequired();

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
