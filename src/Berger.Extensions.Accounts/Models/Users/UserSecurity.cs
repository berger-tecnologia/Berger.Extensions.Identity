namespace Berger.Extensions.Accounts
{
    public partial class UserCore
    {
        public List<Role> Roles { get; set; }
        public List<Claim> Claims { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<UserClaim> UserClaims { get; set; }
        public List<RoleClaim> RoleClaims { get; set; }
    }
}