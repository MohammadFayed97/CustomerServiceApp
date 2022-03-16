namespace Services.Server.Entities.Configurations;

public class ServiceConfiguration : BaseConfiguration<Service>
{
    public override void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Price).IsRequired();

        base.Configure(builder);
    }
}
