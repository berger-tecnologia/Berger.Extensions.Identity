using Berger.Extensions.Jwt;

namespace Berger.Extensions.Accounts
{
    public static class UserHelper
    {
        public static User ConfigurePassword(this User user)
        {
            var salt = SaltService.Create();

            user.SetSalt(salt);

            var hash = user.Password.CreateHash(salt);

            user.SetPassword(hash);

            return user;
        }
    }
}