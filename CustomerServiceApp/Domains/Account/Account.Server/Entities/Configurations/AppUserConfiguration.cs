namespace Account.Server.Entities.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(e => e.FullName).HasMaxLength(100);

        var superAdmin = new AppUser
        {
            Id = new Guid("5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7").ToString(),
            UserName = "Test",
            NormalizedUserName = "Test".ToUpper(),
            Email = "Test@test.com",
            EmailConfirmed = true,
        };
        superAdmin.PasswordHash = new PasswordHasher<AppUser>().HashPassword(superAdmin, "12345");

        builder.HasData(superAdmin);
    }
}
