namespace Services.Client.Components;

public partial class BaseServiceComponent
{
    [Parameter]
    public ServiceViewModel ServiceViewModel { get; set; } = new ServiceViewModel();
    [Parameter]
    public SystemFeatureType SystemFeatureType { get; set; } = SystemFeatureType.Add;

    private async Task HandleValidSubmit()
    {
        try
        {
            string successMessage = string.Empty;
            if (SystemFeatureType.Equals(SystemFeatureType.Add))
            {
                ServiceViewModel = await _serviceHttpService.PostAsync("/api/services", ServiceViewModel);
                successMessage = "Service Added Successfuly";
            }
            else if (SystemFeatureType.Equals(SystemFeatureType.Edit))
            {
                ServiceViewModel = await _serviceHttpService.PutAsync("/api/services", ServiceViewModel);
                successMessage = "Service Edited Successfuly";
            }
            else if(SystemFeatureType.Equals(SystemFeatureType.Delete))
            {
                ServiceViewModel = await _serviceHttpService.DeleteAsync($"/api/services/{ServiceViewModel.Id}");
                successMessage = "Service Deleted Successfuly";
            }
            _toastService.ShowSuccess(successMessage);
            _navigationManager.NavigateTo("/services");
        }
        catch (Exception ex)
        {
            _toastService.ShowError(ex.Message);
        }
    }
}
