using Berger.Extensions.Entities;

namespace Berger.Extensions.Accounts
{
    public class Claim : BaseEntity, IName
    {
        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Properties
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<UserClaim> UserClaims { get; set; }
        public List<RoleClaim> RoleClaims { get; set; }
        #endregion
    }
}