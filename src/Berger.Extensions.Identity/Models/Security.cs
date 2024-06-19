using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Security : BaseEntity, IInput
    {
        public Guid CredentialId { get; set; }
        public string Passphrase { get; set; }
        public string AntiPhishingCode { get; set; }
        public bool TwoFactor { get; set; } = false;
        public bool Identity { get; set; } = false;
        public bool Captcha { get; set; } = false;
        public bool PhoneVerified { get; set; } = false;
        public bool EmailVerified { get; set; } = false;
        public bool TwoFactorVerified { get; set; } = false;
        public DateTime? UserVerifiedOn { get; set; }
        public DateTime? PhoneVerifiedOn { get; set; }
        public DateTime? EmailVerifiedOn { get; set; }
    }
}