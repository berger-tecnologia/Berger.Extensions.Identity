namespace Berger.Extensions.Accounts
{
    public class UserRole : IRole
    {
        #region Methods
        public void SetRoleId(Guid id)
        {
            this.RoleID = id;
        }
        #endregion

        #region Properties
        public Guid RoleID { get; set; }
        public Role Role { get; set; }
        #endregion
    }
}