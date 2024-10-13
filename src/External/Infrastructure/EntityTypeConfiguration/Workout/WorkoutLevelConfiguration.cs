namespace Infrastructure.EntityTypeConfiguration;

public class WorkoutLevelConfiguration : IEntityTypeConfiguration<WorkoutLevel>
{
    public void Configure(EntityTypeBuilder<WorkoutLevel> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Description).HasMaxLength(2000);
        builder.Property(e => e.WorkoutId).IsRequired();


        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
