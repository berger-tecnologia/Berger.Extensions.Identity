namespace Berger.Extensions.Accounts
{
    public class Role
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
        //public List<Module> Modules { get; set; } = null!;
        public List<RoleClaim> RoleClaims { get; set; } = new List<RoleClaim>();
        #endregion

        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetSlug(string slug)
        {
            this.Slug = slug;
        }
        #endregion
    }
}