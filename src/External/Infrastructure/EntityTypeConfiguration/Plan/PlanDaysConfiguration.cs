
namespace Infrastructure.EntityTypeConfiguration;

public class PlanDaysConfiguration : IEntityTypeConfiguration<PlanDays>
{
    public void Configure(EntityTypeBuilder<PlanDays> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.PlanId).IsRequired();

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
