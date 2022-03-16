namespace Cities.Client.Components;

public partial class CityFormViewComponent
{
    [Parameter]
    public Guid CityId { get; set; }
    [Parameter]
    public string SystemFeatureTypeParameter { get; set; }

    private SystemFeatureType systemFeatureType = SystemFeatureType.Add;
    private CityViewModel cityViewModel = new CityViewModel();

    protected override async Task OnInitializedAsync()
    {
        systemFeatureType = (SystemFeatureType)Enum.Parse(typeof(SystemFeatureType), SystemFeatureTypeParameter, true);

        if (systemFeatureType.Equals(SystemFeatureType.Add))
            return;

        cityViewModel = await _cityHttpService.GetByIdAsync($"/api/cities/{CityId.ToString()}");
    }
}
