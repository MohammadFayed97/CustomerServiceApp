namespace CustomerRequests.Client.Components;

public partial class CustomerRequestsFormViewComponent
{
    [Parameter]
    public Guid CustomerRequestId { get; set; }
    [Parameter]
    public string SystemFeatureTypeParameter { get; set; }

    private SystemFeatureType systemFeatureType = SystemFeatureType.Add;
    private CustomerRequestViewModel customerRequestViewModel = new CustomerRequestViewModel();

    protected override async Task OnInitializedAsync()
    {
        systemFeatureType = (SystemFeatureType)Enum.Parse(typeof(SystemFeatureType), SystemFeatureTypeParameter, true);

        if (systemFeatureType.Equals(SystemFeatureType.Add))
            return;

        customerRequestViewModel = await _customerRequestHttpService.GetByIdAsync($"/api/customerRequests/{CustomerRequestId.ToString()}");
    }
}
