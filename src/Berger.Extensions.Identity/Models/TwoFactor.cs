using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class TwoFactor : BaseEntity
    {
        public Guid AccountId { get; set; }
        public bool Active { get; set; } = true;
        public string Secret { get; set; }
        public string Code { get; set; }
    }
}