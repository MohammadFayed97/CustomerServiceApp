namespace CustomerRequests.Client.Components;

public partial class RenderCustomerRequestsComponent
{
    private IEnumerable<CustomerRequestViewModel> customerRequests;

    protected override async Task OnInitializedAsync() => await GetCustomerRequests();

    private async Task GetCustomerRequests()
    {
        try
        {
            customerRequests = await _customerRequestHttpService.GetAsync("/api/customerRequests");
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
