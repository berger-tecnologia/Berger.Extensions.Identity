using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserInput : BaseEntity
    {
        #region Properties
        public Guid? PrivacyId { get; set; }
        public Guid? ProfileId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? SecurityId { get; set; }
        public Guid? PreferenceId { get; set; }
        public Guid? NationalityId { get; set; }
        //public IGender Gender { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Social { get; set; } = string.Empty;
        public string Codename { get; set; } = string.Empty;
        // Temporário
        public string Sub { get; set; } = string.Empty;
        public string Torre { get; set; } = string.Empty;
        public string Apartamento { get; set; } = string.Empty;
        public string Bloco { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        // Temporário
        public bool Claimed { get; set; }
        public bool Online { get; set; }
        public bool Staff { get; set; }
        public bool Verified { get; set; }
        public bool Active { get; set; } = true;
        public DateTime? BannedOn { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? LockedOn { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public DateTime? VerifiedOn { get; set; }
        #endregion

        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }
        #endregion
    }
}