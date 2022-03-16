namespace Customers.Server.UnitOfWorks;

public class CustomerUnitOfWork : BaseUnitOfWork<Customer, CustomerViewModel>, ICustomerUnitOfWork
{
    public CustomerUnitOfWork(ICustomerRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
