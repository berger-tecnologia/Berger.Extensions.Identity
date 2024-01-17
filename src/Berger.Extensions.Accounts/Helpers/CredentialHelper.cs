using Berger.Extensions.Jwt;

namespace Berger.Extensions.Accounts
{
    public static class CredentialHelper
    {
        public static Credential ConfigurePassword(this Credential credential)
        {
            var salt = SaltService.Create();

            credential.SetSalt(salt);

            var hash = credential.Password.CreateHash(salt);

            credential.SetPassword(hash);

            return credential;
        }
    }
}