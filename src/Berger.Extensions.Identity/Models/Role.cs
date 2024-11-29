using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Role : BaseEntity
    {
        #region Properties
        public Guid? ApplicationId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string ConcurrencyStamp { get; set; }
        public List<RoleClaim> RoleClaims { get; set; }
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