using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserRole : UserEntity, IRole
    {
        #region Properties
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        #endregion

        #region Methods
        public void SetRoleId(Guid id)
        {
            this.RoleId = id;
        }
        public void SetUserId(Guid userId)
        {
            this.UserId = userId;
        }
        #endregion
    }
}