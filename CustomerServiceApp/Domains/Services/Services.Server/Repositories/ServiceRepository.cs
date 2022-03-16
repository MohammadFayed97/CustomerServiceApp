namespace Services.Server.Repositories;

public class ServiceRepository : BaseRepository<Service>, IServiceRepository
{
    public ServiceRepository(ApplicationContext context) : base(context)
    {
    }
}
