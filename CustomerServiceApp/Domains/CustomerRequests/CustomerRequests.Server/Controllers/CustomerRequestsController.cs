namespace Account.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerRequestsController : BaseController<CustomerRequest, CustomerRequestViewModel>
{
    public CustomerRequestsController(ICustomerRequestUnitOfWork unitOfWork, IValidator<CustomerRequestViewModel> validator) : base(unitOfWork, validator)
    {
    }
}
