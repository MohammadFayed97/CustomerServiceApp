namespace Services.Client.Components;

public partial class RenderServicesComponent
{
    private IEnumerable<ServiceViewModel> services;

    protected override async Task OnInitializedAsync() => await GetServices();

    private async Task GetServices()
    {
        try
        {
            services = await _serviceHttpService.GetAsync("/api/services");
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
