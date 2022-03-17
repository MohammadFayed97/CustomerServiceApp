namespace CustomerRequests.Server.Entities.Configurations;

public class CustomerRequestConfiguration : BaseConfiguration<CustomerRequest>
{
    public override void Configure(EntityTypeBuilder<CustomerRequest> builder)
    {
        builder.Property(e => e.TransactionDate).IsRequired();

        builder.HasOne(e => e.Customer).WithMany().HasForeignKey(e => e.CustomerId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(e => e.Service).WithMany().HasForeignKey(e => e.ServiceId).IsRequired().OnDelete(DeleteBehavior.NoAction);

        base.Configure(builder);
    }
}
