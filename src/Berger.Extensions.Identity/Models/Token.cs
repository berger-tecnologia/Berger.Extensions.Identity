using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class TokenInput : BaseEntity
    {
        public Guid AccountId { get; set; }
        public string Issuer { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}