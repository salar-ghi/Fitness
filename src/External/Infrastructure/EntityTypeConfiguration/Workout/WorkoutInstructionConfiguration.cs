namespace Infrastructure.EntityTypeConfiguration;

public class WorkoutInstructionConfiguration : IEntityTypeConfiguration<WorkoutInstruction>
{
    public void Configure(EntityTypeBuilder<WorkoutInstruction> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.HasIndex(x => x.WorkoutId);

    }
}
