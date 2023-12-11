using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Account : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string PasswordHash { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsMobileVerified { get; set; }
    }
}