
namespace Infrastructure.EntityTypeConfiguration;

public class MusclePriorityConfiguration : IEntityTypeConfiguration<MusclePriority>
{
    public void Configure(EntityTypeBuilder<MusclePriority> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.PlanId).IsRequired();
        builder.Property(e => e.BodyId).IsRequired();

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
