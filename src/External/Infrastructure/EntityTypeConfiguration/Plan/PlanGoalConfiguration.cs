namespace Infrastructure.EntityTypeConfiguration;

public class PlanGoalConfiguration : IEntityTypeConfiguration<PlanGoals>
{
    public void Configure(EntityTypeBuilder<PlanGoals> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.HasIndex(e => e.PlanId).IsClustered(false);
        builder.Property(e => e.StartDate).IsRequired().HasDefaultValue(DateOnly.MaxValue); // ????

        builder.Property(e => e.StartWeight).IsRequired();
        builder.Property(e => e.StartOverWeight).IsRequired();

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
