namespace Berger.Extensions.Accounts
{
    public class Security
    {
        #region Properties
        public string Passphrase { get; set; }
        public string AntiPhishingCode { get; set; }
        public bool TwoFactor { get; set; }
        public bool Identity { get; set; }
        public bool Captcha { get; set; }
        #endregion
    }
}