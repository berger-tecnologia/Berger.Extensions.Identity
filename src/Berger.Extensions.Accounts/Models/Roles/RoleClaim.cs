namespace Berger.Extensions.Accounts
{
    public class RoleClaim : IClaim, IRole
    {
        #region Properties
        public Guid RoleID { get; set; }
        public Role Role { get; set; }
        public Guid ClaimID { get; set; }
        public Claim Claim { get; set; }
        #endregion
    }
}