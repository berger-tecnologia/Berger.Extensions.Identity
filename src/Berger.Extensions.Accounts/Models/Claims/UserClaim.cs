namespace Berger.Extensions.Accounts
{
    public class UserClaim
    {
        #region Methods
        public void SetClaimId(Guid id)
        {
            this.ClaimID = id;
        }
        #endregion

        #region Properties
        public Guid ClaimID { get; set; }
        public Claim Claim { get; set; }
        public string ClaimType { get; set; } = string.Empty;
        public string ClaimValue { get; set; } = string.Empty;
        #endregion
    }
}