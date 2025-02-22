namespace Infrastructure.EntityTypeConfiguration;

public class BodyConfiguration : IEntityTypeConfiguration<Body>
{
    public void Configure(EntityTypeBuilder<Body> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.Name).IsRequired().HasMaxLength(70);
        

        builder.Property(e => e.ImgUrl).HasMaxLength(256)
            .HasDefaultValue("https://via.placeholder.com/85.png");
        builder.Property(e => e.ParentId).HasDefaultValue(0);
        builder.Property(e => e.Description).IsRequired(false);

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
