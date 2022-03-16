namespace AppSquare.Shared.Client.HttpServices;

public interface IHttpService<TViewModel> where TViewModel : BaseViewModel
{
    Task<TViewModel> DeleteAsync(string url);
    Task<IEnumerable<TViewModel>> GetAsync(string url);
    Task<TViewModel> GetByIdAsync(string url);
    Task<TViewModel> PostAsync(string url, TViewModel viewModel);
    Task<TViewModel> PutAsync(string url, TViewModel viewModel);
}
