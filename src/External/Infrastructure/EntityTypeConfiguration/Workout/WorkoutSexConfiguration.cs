﻿namespace Infrastructure.EntityTypeConfiguration;

public class WorkoutSexConfiguration : IEntityTypeConfiguration<WorkoutSex>
{
    public void Configure(EntityTypeBuilder<WorkoutSex> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.WorkoutId).IsClustered(false);

        builder.Property(e => e.Sex).IsRequired();
    }
}