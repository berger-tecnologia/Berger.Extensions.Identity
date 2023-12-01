using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}