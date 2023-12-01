using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class RoleClaim : UserEntity, IClaimed, IRole
    {
        #region Properties
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = new Role();
        public Guid ClaimId { get; set; }
        public Claim Claim { get; set; } = new Claim();
        #endregion
    }
}