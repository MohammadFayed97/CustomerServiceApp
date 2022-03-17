namespace CustomerRequests.Server.Entities;

public class CustomerRequest : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    public Guid ServiceId { get; set; }
    public Service Service { get; set; }
    public DateTime TransactionDate { get; set; }
}
