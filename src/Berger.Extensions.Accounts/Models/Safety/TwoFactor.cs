using Berger.Extensions.Base;

namespace Berger.Extensions.Accounts
{
    public class TwoFactor : BaseEntity
    {
        #region Properties
        public string Secret { get; set; }
        public string Code { get; set; }
        #endregion
    }
}