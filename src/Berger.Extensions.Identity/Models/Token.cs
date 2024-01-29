using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class TokenInput : BaseEntity, IInput
    {
        public Guid CredentialId { get; set; }
        public string Issuer { get; set; } = string.Empty;
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}