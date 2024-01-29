using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class SocialLogin : BaseEntity
    {
        #region Properties
        public Guid UserId { get; set; }
        public Guid ProviderId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProviderName { get; set; } = string.Empty;
        public string ProviderKey { get; set; } = string.Empty;
        public string ProviderSecret { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        #endregion
    }
}