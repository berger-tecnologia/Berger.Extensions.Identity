using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class RoleClaim : BaseEntity, IClaimed, IRole
    {
        #region Properties
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public Guid ClaimId { get; set; }
        public Claim Claim { get; set; }
        #endregion
    }
}