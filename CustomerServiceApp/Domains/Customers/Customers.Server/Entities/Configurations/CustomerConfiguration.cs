namespace Customers.Server.Entities.Configurations;

public class CustomerConfiguration : BaseConfiguration<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

        builder.HasOne(e => e.City).WithMany().HasForeignKey(e => e.CityId).IsRequired().OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
