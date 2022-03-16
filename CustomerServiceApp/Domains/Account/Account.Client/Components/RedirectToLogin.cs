namespace Account.Client.Components;

using Microsoft.AspNetCore.Components;

public class RedirectToLogin : ComponentBase
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Parameter]
    public string Route { get; set; }
    protected override void OnInitialized()
    {
        NavigationManager.NavigateTo(Route);
    }
}
