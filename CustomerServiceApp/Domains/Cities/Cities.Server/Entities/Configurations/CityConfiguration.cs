namespace Cities.Server.Entities.Configurations;

public class CityConfiguration : BaseConfiguration<City>
{
    public override void Configure(EntityTypeBuilder<City> builder)
    {
        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

        base.Configure(builder);
    }
}
