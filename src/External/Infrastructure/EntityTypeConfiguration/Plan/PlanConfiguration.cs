namespace Infrastructure.EntityTypeConfiguration;

public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.PlanCode).IsRequired().HasMaxLength(70);
        builder.Property(e => e.Level).IsRequired();
        builder.HasIndex(e => e.AthleteId).IsClustered(false);
        builder.Property(e => e.Duration).IsRequired();
        

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
