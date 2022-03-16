namespace Customers.Client.Components;

public partial class CustomerFormViewComponent
{
    [Parameter]
    public Guid CustomerId { get; set; }
    [Parameter]
    public string SystemFeatureTypeParameter { get; set; }

    private SystemFeatureType systemFeatureType = SystemFeatureType.Add;
    private CustomerViewModel customerViewModel = new CustomerViewModel();

    protected override async Task OnInitializedAsync()
    {
        systemFeatureType = (SystemFeatureType)Enum.Parse(typeof(SystemFeatureType), SystemFeatureTypeParameter, true);

        if (systemFeatureType.Equals(SystemFeatureType.Add))
            return;

        customerViewModel = await _customerHttpService.GetByIdAsync($"/api/customers/{CustomerId.ToString()}");
    }
}
