using ModelService.Model;

namespace AuthService.Services
{
    public interface ITokenService
    {
        bool ValidateUser(Author author);
        string BuildToken(string key, string issuer, IEnumerable<string> audience, string userName);
    }
}