namespace Berger.Extensions.Accounts
{
    public class UserRole : IRole
    {
        #region Methods
        public void SetRoleId(Guid id)
        {
            this.RoleId = id;
        }
        #endregion

        #region Properties
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = new Role();
        #endregion
    }
}