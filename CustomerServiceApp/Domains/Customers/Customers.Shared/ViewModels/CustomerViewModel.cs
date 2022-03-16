namespace Customers.Shared.ViewModels;

public class CustomerViewModel : BaseViewModel
{
    public string Name { get; set; }
    public Guid CityId { get; set; }
    public string CityName { get; set; }
}
