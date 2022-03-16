namespace Cities.Client.Components;

public partial class RenderCitiesComponent
{
    private IEnumerable<CityViewModel> cities;

    protected override async Task OnInitializedAsync() => await GetCities();

    private async Task GetCities()
    {
        try
        {
            cities = await _cityHttpService.GetAsync("/api/cities");
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
