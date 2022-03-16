namespace Services.Client.Components;

public partial class ServiceFormViewComponent
{
    [Parameter]
    public Guid ServiceId { get; set; }
    [Parameter]
    public string SystemFeatureTypeParameter { get; set; }

    private SystemFeatureType systemFeatureType = SystemFeatureType.Add;
    private ServiceViewModel serviceViewModel = new ServiceViewModel();

    protected override async Task OnInitializedAsync()
    {
        systemFeatureType = (SystemFeatureType)Enum.Parse(typeof(SystemFeatureType), SystemFeatureTypeParameter, true);

        if (systemFeatureType.Equals(SystemFeatureType.Add))
            return;

        serviceViewModel = await _serviceHttpService.GetByIdAsync($"/api/services/{ServiceId.ToString()}");
    }
}
