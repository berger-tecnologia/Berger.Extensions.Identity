namespace Berger.Extensions.Accounts
{
    public class Security
    {
        #region Properties
        public string Passphrase { get; set; } = string.Empty;
        public string AntiPhishingCode { get; set; } = string.Empty;
        public bool TwoFactor { get; set; }
        public bool Identity { get; set; }
        public bool Captcha { get; set; }
        #endregion
    }
}