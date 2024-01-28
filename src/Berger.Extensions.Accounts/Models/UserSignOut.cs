using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserSignOut : BaseEntity
    {
        public string LogoutId { get; set; } = string.Empty;
    }
}