namespace Account.Client.Components;

using Microsoft.AspNetCore.Components;

public partial class UserLogin
{
    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }

    private UserForLoginViewModel userForLogin = new UserForLoginViewModel();
    private bool showErrors;
    private string error;

    protected override async void OnInitialized()
    {
        if ((await AuthenticationState).User.Identity.IsAuthenticated)
            _navigationManager.NavigateTo("/");

        base.OnInitialized();
    }
    private async Task LoginUser()
    {
        try
        {
            showErrors = false;

            var response = await _authenticationService.Login("api/Account/login", userForLogin);
            if (!response.IsAuthSuccessful)
            {
                error = response.ErrorMessage;
                showErrors = true;
            }
            else
            {
                _navigationManager.NavigateTo("/");
            }
        }
        catch (Exception ex)
        {
            error = ex.Message;
            showErrors = true;
        }
    }
}
