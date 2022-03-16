namespace Customers.Client.Components;

public partial class BaseCustomerComponent
{
    [Parameter]
    public CustomerViewModel CustomerViewModel { get; set; } = new CustomerViewModel();
    [Parameter]
    public SystemFeatureType SystemFeatureType { get; set; } = SystemFeatureType.Add;

    private IEnumerable<CityViewModel> cities = new List<CityViewModel>();
    protected override async Task OnInitializedAsync()
    {
        cities = await _cityHttpService.GetAsync("/api/cities");
    }
    private async Task HandleValidSubmit()
    {
        string successMessage = string.Empty;
        if (SystemFeatureType.Equals(SystemFeatureType.Add))
        {
            CustomerViewModel = await _customerHttpService.PostAsync("/api/customers", CustomerViewModel);
            successMessage = "Customer Added Successfuly";
        }
        else if (SystemFeatureType.Equals(SystemFeatureType.Edit))
        {
            CustomerViewModel = await _customerHttpService.PutAsync("/api/customers", CustomerViewModel);
            successMessage = "Customer Edited Successfuly";
        }
        else if (SystemFeatureType.Equals(SystemFeatureType.Delete))
        {
            CustomerViewModel = await _customerHttpService.DeleteAsync($"/api/customers/{CustomerViewModel.Id}");
            successMessage = "Customer Deleted Successfuly";
        }
        _toastService.ShowSuccess(successMessage);
        _navigationManager.NavigateTo("/customers");
    }
}
