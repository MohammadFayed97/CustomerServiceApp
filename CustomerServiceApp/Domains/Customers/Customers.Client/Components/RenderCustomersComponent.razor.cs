namespace Customers.Client.Components;

public partial class RenderCustomersComponent
{
    private IEnumerable<CustomerViewModel> customers;

    protected override async Task OnInitializedAsync() => await GetCustomers();

    private async Task GetCustomers()
    {
        try
        {
            customers = await _customerHttpService.GetAsync("/api/customers");
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
