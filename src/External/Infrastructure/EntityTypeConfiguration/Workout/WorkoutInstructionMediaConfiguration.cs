namespace Infrastructure.EntityTypeConfiguration;

internal class WorkoutInstructionMediaConfiguration : IEntityTypeConfiguration<WorkoutInstructionMedia>
{
    public void Configure(EntityTypeBuilder<WorkoutInstructionMedia> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.HasIndex(x => x.WorkoutId);
    }
}
