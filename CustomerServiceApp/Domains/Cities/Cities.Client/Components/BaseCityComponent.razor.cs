namespace Cities.Client.Components;

public partial class BaseCityComponent
{
    [Parameter]
    public CityViewModel CityViewModel { get; set; } = new CityViewModel();
    [Parameter]
    public SystemFeatureType SystemFeatureType { get; set; } = SystemFeatureType.Add;

    private async Task HandleValidSubmit()
    {
        try
        {
            string successMessage = string.Empty;
            if (SystemFeatureType.Equals(SystemFeatureType.Add))
            {
                CityViewModel = await _cityHttpService.PostAsync("/api/cities", CityViewModel);
                successMessage = "City Added Successfuly";
            }
            else if (SystemFeatureType.Equals(SystemFeatureType.Edit))
            {
                CityViewModel = await _cityHttpService.PutAsync("/api/cities", CityViewModel);
                successMessage = "City Edited Successfuly";
            }
            else if(SystemFeatureType.Equals(SystemFeatureType.Delete))
            {
                CityViewModel = await _cityHttpService.DeleteAsync($"/api/cities/{CityViewModel.Id}");
                successMessage = "City Deleted Successfuly";
            }
            _toastService.ShowSuccess(successMessage);
            _navigationManager.NavigateTo("/cities");
        }
        catch (Exception ex)
        {
            _toastService.ShowError(ex.Message);
        }
    }
}
