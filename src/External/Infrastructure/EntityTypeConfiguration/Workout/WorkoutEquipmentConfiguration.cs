namespace Infrastructure.EntityTypeConfiguration;

public class WorkoutEquipmentConfiguration : IEntityTypeConfiguration<WorkoutEquipment>
{
    public void Configure(EntityTypeBuilder<WorkoutEquipment> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => new { e.WorkoutId, e.EquipmentId });


        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
