namespace CustomerRequests.Client.Components;

using Customers.Shared.ViewModels;
using Services.Shared.ViewModels;

public partial class BaseCustomerRequestsComponent
{
    [Parameter]
    public CustomerRequestViewModel CustomerRequestViewModel { get; set; } = new CustomerRequestViewModel();
    [Parameter]
    public SystemFeatureType SystemFeatureType { get; set; } = SystemFeatureType.Add;

    private IEnumerable<CustomerViewModel> customers = new List<CustomerViewModel>();
    private IEnumerable<ServiceViewModel> services = new List<ServiceViewModel>();
    protected override async Task OnInitializedAsync()
    {
        Task<IEnumerable<CustomerViewModel>> getCustomersTask = _customerHttpService.GetAsync("/api/customers");
        Task<IEnumerable<ServiceViewModel>> getServicesTask = _serviceHttpService.GetAsync("/api/services");

        await Task.WhenAll(getCustomersTask, getServicesTask);

        customers = await getCustomersTask;
        services = await getServicesTask;

        StateHasChanged();
    }
    private async Task HandleValidSubmit()
    {
        string successMessage = string.Empty;
        if (SystemFeatureType.Equals(SystemFeatureType.Add))
        {
            CustomerRequestViewModel = await _customerRequestHttpService.PostAsync("/api/customerRequests", CustomerRequestViewModel);
            successMessage = "CustomerRequests Added Successfuly";
        }
        else if (SystemFeatureType.Equals(SystemFeatureType.Edit))
        {
            CustomerRequestViewModel = await _customerRequestHttpService.PutAsync("/api/customerRequests", CustomerRequestViewModel);
            successMessage = "CustomerRequests Edited Successfuly";
        }
        else if (SystemFeatureType.Equals(SystemFeatureType.Delete))
        {
            CustomerRequestViewModel = await _customerRequestHttpService.DeleteAsync($"/api/customerRequests/{CustomerRequestViewModel.Id}");
            successMessage = "CustomerRequests Deleted Successfuly";
        }
        _toastService.ShowSuccess(successMessage);
        _navigationManager.NavigateTo("/customerRequests");
    }
}
