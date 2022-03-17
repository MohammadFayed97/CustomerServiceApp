namespace AppSquare.Shared.Client.HttpServices;

using Blazored.Toast.Services;

public class HttpService<TViewModel> : IHttpService<TViewModel> 
    where TViewModel : BaseViewModel
{
    private readonly HttpClient _httpClient;
    private readonly IToastService _toastService;

    public HttpService(HttpClient httpClient, IToastService toastService)
    {
        _httpClient = httpClient;
        _toastService = toastService;
    }

    public virtual async Task<IEnumerable<TViewModel>> GetAsync(string url)
    {
        IEnumerable<TViewModel> viewModels = new List<TViewModel>();
        try
        {
            HttpResponseMessage result = await _httpClient.GetAsync(url);
            string content = await result.Content.ReadAsStringAsync();

            if (!result.IsSuccessStatusCode)
            {
                // Can log here
                Console.WriteLine(content);
                throw new Exception(content);
            }

            Console.WriteLine("Get successfully");
            viewModels = JsonConvert.DeserializeObject<IEnumerable<TViewModel>>(content);
            return viewModels;
        }
        catch (Exception exception)
        {
            // Can log here
            Console.WriteLine(exception.Message);
            _toastService.ShowToast(ToastLevel.Error, exception.Message);
        }
        return viewModels;
    }
    public virtual async Task<TViewModel> GetByIdAsync(string url)
    {
        TViewModel cityViewModel = null;
        try
        {
            HttpResponseMessage result = await _httpClient.GetAsync(url);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(resultContent);
                throw new Exception(resultContent);
            }

            Console.WriteLine("GetById successfully");
            cityViewModel = JsonConvert.DeserializeObject<TViewModel>(resultContent);
            return cityViewModel;
        }
        catch (Exception exception)
        {
            // Can log here
            Console.WriteLine(exception.Message);
            _toastService.ShowError(exception.Message);
        }
        return cityViewModel;
    }
    public virtual async Task<TViewModel> PostAsync(string url, TViewModel viewModel)
    {
        try
        {
            var content = JsonConvert.SerializeObject(viewModel);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            HttpResponseMessage result = await _httpClient.PostAsync(url, bodyContent);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log or show Toaster with message that contain that error.
                Console.WriteLine(resultContent);
                throw new Exception(resultContent);
            }

            Console.WriteLine("Post successfully");
            viewModel = JsonConvert.DeserializeObject<TViewModel>(resultContent);
            return viewModel;
        }
        catch (Exception exception)
        {
            // Can log here
            Console.WriteLine(exception.Message);
            _toastService.ShowError(exception.Message);
        }
        return viewModel;
    }
    public virtual async Task<TViewModel> PutAsync(string url, TViewModel viewModel)
    {
        try
        {
            var content = JsonConvert.SerializeObject(viewModel);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            HttpResponseMessage result = await _httpClient.PutAsync(url, bodyContent);

            string resultContent = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                // Can log here
                Console.WriteLine(resultContent);
                throw new Exception(resultContent);
            }

            Console.WriteLine("Put successfully");
            viewModel = JsonConvert.DeserializeObject<TViewModel>(resultContent);
            return viewModel;
        }
        catch (Exception exception)
        {
            // Can log here
            Console.WriteLine(exception.Message);
            _toastService.ShowError(exception.Message);
        }
        return viewModel;
    }
    public virtual async Task<TViewModel> DeleteAsync(string url)
    {
        TViewModel viewModel = null;
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
            viewModel = JsonConvert.DeserializeObject<TViewModel>(resultContent);
            return viewModel;
        }
        catch (Exception exception)
        {
            // Can log here
            Console.WriteLine(exception.Message);
            _toastService.ShowError(exception.Message);
        }
        return viewModel;
    }
}
