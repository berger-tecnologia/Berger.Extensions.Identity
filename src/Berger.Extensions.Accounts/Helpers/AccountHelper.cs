using Berger.Extensions.Jwt;

namespace Berger.Extensions.Accounts
{
    public static class AccountHelper
    {
        public static Account ConfigurePassword(this Account account)
        {
            var salt = SaltService.Create();

            account.SetSalt(salt);

            var hash = account.Password.CreateHash(salt);

            account.SetPassword(hash);

            return account;
        }
    }
}