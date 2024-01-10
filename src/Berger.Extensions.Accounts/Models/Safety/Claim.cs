using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Claim : BaseEntity
    {
        #region Properties
        public Guid OwnerId { get; set; }
        public Guid? EntityId { get; set; }
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