namespace Berger.Extensions.Accounts
{
    public class Claim : UserEntity
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<UserClaim> UserClaims { get; set; }
        public List<RoleClaim> RoleClaims { get; set; }
        #endregion

        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        #endregion
    }
}