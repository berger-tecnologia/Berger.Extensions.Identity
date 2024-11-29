using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class SocialLogin : BaseEntity
    {
        #region Properties
        public Guid UserId { get; set; }
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string ProviderName { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderSecret { get; set; }
        #endregion

        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        #endregion
    }
}