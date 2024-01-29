using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Reset : BaseEntity
    {
        public Guid DeviceId { get; }
        public Guid CredentialId { get; }
    }
}