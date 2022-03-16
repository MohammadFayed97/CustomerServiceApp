namespace CustomerServiceApp.Server.MapperProfiles;

using AutoMapper;
using Cities.Server.Entities;
using Cities.Shared.ViewModels;
using Services.Server.Entities;
using Services.Shared.ViewModels;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<City, CityViewModel>().ReverseMap();
        CreateMap<Service, ServiceViewModel>().ReverseMap();
    }
}
