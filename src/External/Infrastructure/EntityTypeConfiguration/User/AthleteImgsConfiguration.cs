
namespace Infrastructure.EntityTypeConfiguration;

public class AthleteImgsConfiguration : IEntityTypeConfiguration<AthleteImgs>
{
    public void Configure(EntityTypeBuilder<AthleteImgs> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.AthleteId).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(2500);

        builder.Property(e => e.ImgUrl).HasMaxLength(256)
            .HasDefaultValue("https://via.placeholder.com/85.png");

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
