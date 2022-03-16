namespace Cities.Client.HttpServices
{
    using Cities.Shared.ViewModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICityHttpService
    {
        Task<CityViewModel> DeleteCityAsync(string url);
        Task<IEnumerable<CityViewModel>> GetCitiesAsync(string url);
        Task<CityViewModel> GetCityByIdAsync(string url);
        Task<CityViewModel> PostCityAsync(string url, CityViewModel cityViewModel);
        Task<CityViewModel> PutCityAsync(string url, CityViewModel cityViewModel);
    }
}