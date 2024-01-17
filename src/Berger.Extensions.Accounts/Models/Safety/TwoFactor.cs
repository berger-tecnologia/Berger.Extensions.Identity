using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class TwoFactor : BaseEntity
    {
        public Guid CredentialId { get; set; }
        public bool Active { get; set; }
        public string Secret { get; set; }
        public string Code { get; set; }
    }
}