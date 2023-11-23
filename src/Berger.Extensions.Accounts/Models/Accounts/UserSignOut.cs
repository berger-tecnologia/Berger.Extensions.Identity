using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserSignOut : BaseEntity, IInput
    {
        public string LogoutId { get; set; } = string.Empty;
    }
}