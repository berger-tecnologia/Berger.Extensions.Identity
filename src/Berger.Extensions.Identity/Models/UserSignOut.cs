using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class UserSignOut : BaseEntity
    {
        public string LogoutId { get; set; } = string.Empty;
    }
}