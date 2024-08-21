namespace Infrastructure.EntityTypeConfiguration;

public class AthleteConfiguration : IEntityTypeConfiguration<Athlete>
{
    public void Configure(EntityTypeBuilder<Athlete> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.UserId).IsRequired();
        builder.Property(e => e.Gender).IsRequired();
        
        builder.Property(e => e.Age).IsRequired();
        builder.Property(e => e.BodyType).IsRequired();
        builder.Property(e => e.Level).IsRequired();
        

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
