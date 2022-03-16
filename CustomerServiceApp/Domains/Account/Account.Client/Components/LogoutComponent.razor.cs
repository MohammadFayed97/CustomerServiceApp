namespace Account.Client.Components;

public partial class LogoutComponent
{
    protected override async Task OnInitializedAsync()
    {
        await _authenticationService.Logout();
        _navigationManager.NavigateTo("/");
    }
}
