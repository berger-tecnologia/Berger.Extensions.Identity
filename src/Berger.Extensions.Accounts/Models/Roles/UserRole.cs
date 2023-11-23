using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserRole : BaseEntity, IRole
    {
        #region Methods
        public void SetRoleId(Guid id)
        {
            this.RoleId = id;
        }
        #endregion

        #region Properties
        public Guid RoleId { get; set; }
        public Guid UserId { get; set; }
        public Role Role { get; set; } = new Role();
        #endregion
    }
}