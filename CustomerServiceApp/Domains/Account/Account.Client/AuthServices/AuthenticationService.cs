namespace Account.Client.AuthServices;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorage;
    private readonly AuthenticationStateProvider _authStateProvider;

    public AuthenticationService(HttpClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authStateProvider)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
        _authStateProvider = authStateProvider;
    }

    public async Task<AuthResponseViewModel> Login(UserForLoginViewModel userForLogin)
    {
        string content = JsonConvert.SerializeObject(userForLogin);
        StringContent bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        HttpResponseMessage authResult = await _httpClient.PostAsync("api/Account/login", bodyContent);
        string authContent = await authResult.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<AuthResponseViewModel>(authContent);

        if (!authResult.IsSuccessStatusCode)
            return result;

        await _localStorage.SetItemAsync<string>("AuthToken", result.Token);
        ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(userForLogin.UserName);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.Token);

        return new AuthResponseViewModel { IsAuthSuccessful = true };
    }
    public async Task Logout()
    {
        await _localStorage.RemoveItemAsync("AuthToken");
        ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
        _httpClient.DefaultRequestHeaders.Authorization = null;
    }
}
