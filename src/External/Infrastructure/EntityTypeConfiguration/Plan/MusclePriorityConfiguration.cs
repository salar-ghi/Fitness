
namespace Infrastructure.EntityTypeConfiguration;

public class MusclePriorityConfiguration : IEntityTypeConfiguration<MusclePriority>
{
    public void Configure(EntityTypeBuilder<MusclePriority> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.PlanId).IsClustered(false);
        builder.HasIndex(e => e.BodyId).IsClustered(false);

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
