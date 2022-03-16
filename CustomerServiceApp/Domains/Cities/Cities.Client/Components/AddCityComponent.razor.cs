namespace Cities.Client.Components
{
    using Cities.Shared.ViewModels;
    using System.Threading.Tasks;

    public partial class AddCityComponent
    {
        private CityViewModel cityViewModel = new CityViewModel();

        private async Task HandleValidSubmit()
        {
            cityViewModel = await _cityHttpService.PostCityAsync("/api/cities", cityViewModel);
            _toastService.ShowSuccess("City Added Successfuly");
            _navigationManager.NavigateTo("/cities");
        }
    }
}
