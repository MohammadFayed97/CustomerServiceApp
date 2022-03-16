namespace Cities.Server.UnitOfWorks;

public class CityUnitOfWork : BaseUnitOfWork<City, CityViewModel>, ICityUnitOfWork
{
    public CityUnitOfWork(ICityRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
