namespace Infrastructure.EntityTypeConfiguration;

public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
{
    public void Configure(EntityTypeBuilder<Workout> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.Property(e => e.Name).IsRequired().HasMaxLength(150);
        builder.Property(e => e.Description).HasMaxLength(2500).IsRequired(false);
        builder.HasIndex(e => e.SportId).IsClustered(false);

        builder.Property(e => e.ImgUrl).HasMaxLength(256)
            .HasDefaultValue("https://via.placeholder.com/85.png");

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);

    }
}
