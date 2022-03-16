namespace Cities.Client.Components;

using Cities.Shared.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

public partial class EditCityComponent
{
    [Parameter]
    public Guid CityId { get; set; }

    private CityViewModel cityViewModel = new CityViewModel();

    protected override async Task OnInitializedAsync()
    {
        cityViewModel = await _cityHttpService.GetCityByIdAsync($"/api/cities/{CityId}");
    }
    private async Task HandleValidSubmit()
    {
        cityViewModel = await _cityHttpService.PutCityAsync("/api/cities", cityViewModel);
        _toastService.ShowSuccess("City Edited Successfuly");
        _navigationManager.NavigateTo("/cities");
    }
}
