namespace Account.Client.Components;

public partial class CreateUserComponent
{
    private UserForRegisterViewModel userForRegister = new UserForRegisterViewModel();
    private bool showErrors;
    private bool showSuccess;
    private IEnumerable<string> errors;
    private async Task RegisterUser()
    {

        showErrors = false;
        showSuccess = false;

        var response = await _authenticationService.CreateUser("api/Account/RegisterUser", userForRegister);
        if (!response.IsSucceeded)
        {
            errors = response.Errors;
            showErrors = true;
        }
        else
        {
            showSuccess = true;
        }
        userForRegister = new UserForRegisterViewModel();
    }
}
