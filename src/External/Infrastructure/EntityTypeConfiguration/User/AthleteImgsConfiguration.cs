
namespace Infrastructure.EntityTypeConfiguration;

public class AthleteImgsConfiguration : IEntityTypeConfiguration<AthleteImgs>
{
    public void Configure(EntityTypeBuilder<AthleteImgs> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.HasIndex(e => e.AthleteId).IsClustered(false);
        builder.Property(e => e.Description).HasMaxLength(2500).IsRequired(false);

        builder.Property(e => e.ImgUrl).HasMaxLength(256)
            .HasDefaultValue("https://via.placeholder.com/85.png");

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
