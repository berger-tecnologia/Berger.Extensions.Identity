using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserClaim : BaseEntity
    {
        #region Properties
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid ClaimId { get; set; }
        public Claim Claim { get; set; }
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