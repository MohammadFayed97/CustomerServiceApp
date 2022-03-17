namespace CustomerRequests.Shared.ViewModels;

public class CustomerRequestViewModel : BaseViewModel
{
    public Guid CustomerId { get; set; }
    public string CustomerName { get; set; }
    public Guid ServiceId { get; set; }
    public string ServiceName { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.Now;
}
