namespace Infrastructure.EntityTypeConfiguration;

public class AthleteConfiguration : IEntityTypeConfiguration<Athlete>
{
    public void Configure(EntityTypeBuilder<Athlete> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => new { e.UserId, e.Gender }).IsClustered(false);        
        
        builder.Property(e => e.AgeRange).IsRequired();
        builder.Property(e => e.BodyType).IsRequired();
        builder.Property(e => e.Level).IsRequired();
        

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
