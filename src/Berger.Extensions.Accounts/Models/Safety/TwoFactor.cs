namespace Berger.Extensions.Accounts
{
    public class TwoFactor
    {
        #region Properties
        public string Secret { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        #endregion
    }
}