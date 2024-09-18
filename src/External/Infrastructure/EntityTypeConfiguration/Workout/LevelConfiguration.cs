namespace Infrastructure.EntityTypeConfiguration;

public class LevelConfiguration : IEntityTypeConfiguration<Level>
{
    public void Configure(EntityTypeBuilder<Level> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).IsRequired().HasMaxLength(70);
        builder.Property(e => e.Description).HasMaxLength(2000);
        builder.Property(e => e.WorkoutId).IsRequired();


        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
