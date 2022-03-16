namespace Account.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAuthenticationManager _authenticationManager;
    private readonly IApplicationUserRepository _applicationUserRepository;

    public AccountController(IAuthenticationManager authenticationManager, IApplicationUserRepository applicationUserRepository)
    {
        _authenticationManager = authenticationManager;
        _applicationUserRepository = applicationUserRepository;
    }

    [HttpPost("RegisterUser")]
    public async Task<IActionResult> RegisterUser(UserForRegisterViewModel userForRegister)
    {
        if (userForRegister == null)
            return BadRequest("User is null");

        IdentityResult result = await _applicationUserRepository.RegisterUser(userForRegister);
        if (!result.Succeeded)
        {
            IEnumerable<string> errors = result.Errors.Select(e => e.Description);
            return BadRequest(new { errors });
        }

        return StatusCode(201);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserForLoginViewModel userLogin)
    {
        if (!await _authenticationManager.ValidateUser(userLogin))
            return Unauthorized(new AuthResponseViewModel { ErrorMessage = "Invalid UserName Or Password"}); 

        return Ok(new AuthResponseViewModel { IsAuthSuccessful = true, Token = await _authenticationManager.CreateToken() });
    }
}
