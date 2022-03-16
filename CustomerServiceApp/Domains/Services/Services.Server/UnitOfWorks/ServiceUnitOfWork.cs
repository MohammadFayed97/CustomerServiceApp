namespace Services.Server.UnitOfWorks;

public class ServiceUnitOfWork : BaseUnitOfWork<Service, ServiceViewModel>, IServiceUnitOfWork
{
    public ServiceUnitOfWork(IServiceRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
