namespace Cities.Server.Repositories;

public class CityRepository : BaseRepository<City>, ICityRepository
{
    public CityRepository(ApplicationContext context) : base(context)
    {
    }
}
