namespace Infrastructure.EntityTypeConfiguration;

public class WorkoutInstructionConfiguration : IEntityTypeConfiguration<WorkoutInstruction>
{
    public void Configure(EntityTypeBuilder<WorkoutInstruction> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.WorkoutId);

    }
}
