using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class UserVerification : BaseEntity
    {
        public string Code { get; set; }
        public Guid VerificationId { get; set; }
    }
}