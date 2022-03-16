namespace Account.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : BaseController<Customer, CustomerViewModel>
{
    public CustomersController(ICustomerUnitOfWork unitOfWork, IValidator<CustomerViewModel> validator) : base(unitOfWork, validator)
    {
    }
}
