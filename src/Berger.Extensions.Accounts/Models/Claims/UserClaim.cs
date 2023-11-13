namespace Berger.Extensions.Accounts
{
    public class UserClaim
    {
        #region Methods
        public void SetClaimId(Guid id)
        {
            this.ClaimId = id;
        }
        #endregion

        #region Properties
        public Guid ClaimId { get; set; }
        public Claim Claim { get; set; } = new Claim();
        public string ClaimType { get; set; } = string.Empty;
        public string ClaimValue { get; set; } = string.Empty;
        #endregion
    }
}