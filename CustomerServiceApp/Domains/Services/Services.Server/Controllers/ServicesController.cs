namespace Account.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController : BaseController<Service, ServiceViewModel>
{
    public ServicesController(IServiceUnitOfWork unitOfWork, IValidator<ServiceViewModel> validator) : base(unitOfWork, validator)
    {
    }
}
