namespace Cities.Client.HttpServices;

using Cities.Shared.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CityHttpService : ICityHttpService
{
    private readonly HttpClient _httpClient;

    public CityHttpService(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<IEnumerable<CityViewModel>> GetCitiesAsync(string url)
    {
        IEnumerable<CityViewModel> viewModels = new List<CityViewModel>();
        try
        {
            HttpResponseMessage result = await _httpClient.GetAsync(url);
            string content = await result.Content.ReadAsStringAsync();

            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(content);
            }

            Console.WriteLine("Get successfully");
            viewModels = JsonConvert.DeserializeObject<IEnumerable<CityViewModel>>(content);
            return viewModels;
        }
        catch (Exception ex)
        {
            // Can log or show Toaster
            Console.WriteLine(ex.Message);
        }
        return viewModels;
    }
    public async Task<CityViewModel> GetCityByIdAsync(string url)
    {
        CityViewModel cityViewModel = new CityViewModel();
        try
        {
            HttpResponseMessage result = await _httpClient.GetAsync(url);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(resultContent);
            }

            Console.WriteLine("GetById successfully");
            cityViewModel = JsonConvert.DeserializeObject<CityViewModel>(resultContent);
            return cityViewModel;
        }
        catch (Exception ex)
        {
            // Can log or show Toaster
            Console.WriteLine(ex.Message);
        }
        return cityViewModel;
    }
    public async Task<CityViewModel> PostCityAsync(string url, CityViewModel cityViewModel)
    {
        try
        {
            var content = JsonConvert.SerializeObject(cityViewModel);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            HttpResponseMessage result = await _httpClient.PostAsync(url, bodyContent);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(resultContent);
            }

            Console.WriteLine("Post successfully");
            cityViewModel = JsonConvert.DeserializeObject<CityViewModel>(resultContent);
            return cityViewModel;
        }
        catch (Exception ex)
        {
            // Can log or show Toaster
            Console.WriteLine(ex.Message);
        }
        return cityViewModel;
    }
    public async Task<CityViewModel> PutCityAsync(string url, CityViewModel cityViewModel)
    {
        try
        {
            var content = JsonConvert.SerializeObject(cityViewModel);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            HttpResponseMessage result = await _httpClient.PutAsync(url, bodyContent);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(resultContent);
            }

            Console.WriteLine("Put successfully");
            cityViewModel = JsonConvert.DeserializeObject<CityViewModel>(resultContent);
            return cityViewModel;
        }
        catch (Exception ex)
        {
            // Can log or show Toaster
            Console.WriteLine(ex.Message);
        }
        return cityViewModel;
    }
    public async Task<CityViewModel> DeleteCityAsync(string url)
    {
        CityViewModel cityViewModel = new CityViewModel();
        try
        {
            HttpResponseMessage result = await _httpClient.DeleteAsync(url);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(resultContent);
            }

            Console.WriteLine("Delete successfully");
            cityViewModel = JsonConvert.DeserializeObject<CityViewModel>(resultContent);
            return cityViewModel;
        }
        catch (Exception ex)
        {
            // Can log or show Toaster
            Console.WriteLine(ex.Message);
        }
        return cityViewModel;
    }
}
