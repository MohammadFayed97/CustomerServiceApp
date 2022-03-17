namespace AppSquare.Shared.Client.HttpServices;

using AppSquare.Shared.Client.AuthServices;
using Toolbelt.Blazor;

public class HttpInterceptorService
{
    private readonly HttpClientInterceptor _interceptor;
    private readonly IRefreshTokenService _refreshTokenService;
    public HttpInterceptorService(HttpClientInterceptor interceptor, IRefreshTokenService refreshTokenService)
    {
        _interceptor = interceptor;
        _refreshTokenService = refreshTokenService;
    }
    public void RegisterEvent() => _interceptor.BeforeSendAsync += InterceptBeforeHttpAsync;
    public async Task InterceptBeforeHttpAsync(object sender, HttpClientInterceptorEventArgs e)
    {
        var absPath = e.Request.RequestUri.AbsolutePath;
        if (!absPath.Contains("account"))
        {
            var token = await _refreshTokenService.TryRefreshToken("api/account/refresh");
            if (!string.IsNullOrEmpty(token))
            {
                e.Request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
    public void DisposeEvent() => _interceptor.BeforeSendAsync -= InterceptBeforeHttpAsync;
}
