
namespace Infrastructure.EntityTypeConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).IsRequired().HasMaxLength(70);
        builder.Property(e => e.Email).HasMaxLength(70);
        builder.Property(e => e.CellPhone).IsRequired().HasMaxLength(30);

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.Password).HasMaxLength(500);

        builder.Property(e => e.ImgUrl).HasMaxLength(256)
            .HasDefaultValue("https://via.placeholder.com/85.png");

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
