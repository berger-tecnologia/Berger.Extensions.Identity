using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserVerification : BaseEntity
    {
        public string Code { get; set; } = string.Empty;
        public Guid VerificationId { get; set; }
    }
}