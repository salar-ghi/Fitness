namespace Infrastructure.EntityTypeConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.Property(e => e.FName).IsRequired().HasMaxLength(40);
        builder.Property(e => e.LName).IsRequired().HasMaxLength(40);
        builder.Property(e => e.Email).HasMaxLength(70);
        builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(30);

        builder.Property(e => e.UserName).HasMaxLength(50);

        //builder.Property(e => e.Password).HasMaxLength(30);

        builder.Property(e => e.ImgUrl).HasMaxLength(256)
            .HasDefaultValue("https://via.placeholder.com/85.png");

        builder.Property(e => e.IsDeleted).HasDefaultValue(false);
        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.Modified).IsRequired().HasDefaultValue(DateTime.UtcNow);
    }
}
