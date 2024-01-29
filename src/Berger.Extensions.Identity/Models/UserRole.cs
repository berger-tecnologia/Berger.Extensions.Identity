using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class UserRole : BaseEntity, IRole
    {
        #region Properties
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid ApplicationId { get; set; }
        #endregion

        #region Navigation
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