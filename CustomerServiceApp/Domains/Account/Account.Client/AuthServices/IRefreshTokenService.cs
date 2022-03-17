namespace Account.Client.AuthServices
{
    using System.Threading.Tasks;

    public interface IRefreshTokenService
    {
        Task<string> TryRefreshToken();
    }
}