namespace Cities.Client.Components;

using Cities.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
