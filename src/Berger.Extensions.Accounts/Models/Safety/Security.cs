using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Security : BaseEntity, IInput
    {
        public Guid AccountId { get; set; }
        public string Passphrase { get; set; }
        public string AntiPhishingCode { get; set; }
        public bool TwoFactor { get; set; }
        public bool Identity { get; set; }
        public bool Captcha { get; set; }
        public bool PhoneVerified { get; set; }
        public bool EmailVerified { get; set; }
        public bool TwoFactorVerified { get; set; }
        public DateTime? UserVerifiedOn { get; set; }
        public DateTime? PhoneVerifiedOn { get; set; }
        public DateTime? EmailVerifiedOn { get; set; }
    }
}