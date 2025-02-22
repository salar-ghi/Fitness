namespace Infrastructure.EntityTypeConfiguration;

public class BodyFatConfiguration : IEntityTypeConfiguration<BodyFat>
{
    public void Configure(EntityTypeBuilder<BodyFat> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.bodyId).IsRequired();
        builder.Property(e => e.PlanId).IsRequired();
    }
}
