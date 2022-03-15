namespace Account.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAuthenticationManager _authenticationManager;

    public AccountController(IAuthenticationManager authenticationManager)
    {
        _authenticationManager = authenticationManager;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserForLoginViewModel userLogin)
    {
        if (!await _authenticationManager.ValidateUser(userLogin))
            return Unauthorized(new AuthResponseViewModel { ErrorMessage = "Invalid UserName Or Password"}); 

        return Ok(new AuthResponseViewModel { IsAuthSuccessful = true, Token = await _authenticationManager.CreateToken() });
    }
}
