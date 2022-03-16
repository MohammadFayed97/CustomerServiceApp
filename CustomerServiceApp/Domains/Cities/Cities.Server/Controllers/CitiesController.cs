namespace Account.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitiesController : BaseController<City, CityViewModel>
{
    public CitiesController(ICityUnitOfWork unitOfWork, IValidator<CityViewModel> validator) : base(unitOfWork, validator)
    {
    }
}
