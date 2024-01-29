using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Role : BaseEntity
    {
        #region Properties
        public Guid? OwnerId { get; set; }
        public Guid? ApplicationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
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