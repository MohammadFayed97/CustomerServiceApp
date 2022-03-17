namespace CustomerRequests.Server.UnitOfWorks;

public class CustomerRequestUnitOfWork : BaseUnitOfWork<CustomerRequest, CustomerRequestViewModel>, ICustomerRequestUnitOfWork
{
    public CustomerRequestUnitOfWork(ICustomerRequestRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
