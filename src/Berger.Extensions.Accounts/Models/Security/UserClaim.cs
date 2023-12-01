using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserClaim : UserEntity
    {
        #region Properties
        public Guid ClaimId { get; set; }
        public Claim Claim { get; set; } = new Claim();
        public string ClaimType { get; set; } = string.Empty;
        public string ClaimValue { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetClaimId(Guid id)
        {
            this.ClaimId = id;
        }
        #endregion
    }
}