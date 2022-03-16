namespace Account.Client.Components;

public partial class UserLogin
{
    private UserForLoginViewModel userForLogin = new UserForLoginViewModel();
    private bool showErrors;
    private string error;

    private async Task LoginUser()
    {
        try
        {
            showErrors = false;

            var response = await _authenticationService.Login(userForLogin);
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
