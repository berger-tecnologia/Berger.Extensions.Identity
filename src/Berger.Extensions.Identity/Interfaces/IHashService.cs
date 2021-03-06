namespace Berger.Extensions.Identity
{
    public interface IHashService
    {
        string Create(string password, string salt);
        bool Validate(string password, string salt, string hash);
    }
}