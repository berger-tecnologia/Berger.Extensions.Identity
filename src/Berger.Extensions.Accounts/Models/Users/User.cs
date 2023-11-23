using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class User : BaseEntity, IUser<IGender>
    {
        #region Factories
        private readonly IMediaFactory _media;
        private readonly IAddressFactory _address;
        //private readonly IAttributeValue _attributeValue;
        #endregion

        #region Constructors
        public User()
        {
        }
        public User(IAddressFactory address, IMediaFactory media)
        {
            _media = media;
            _address = address;
        }
        #endregion

        #region Factory Properties
        public IMedia Avatar { get; set; }
        public List<IMedia> Medias { get; set; } = new List<IMedia>();
        public List<IAddress> Addresses { get; set; } = new List<IAddress>();
        //public List<IAttributeValue> AttributeValues { get; set; }
        #endregion

        #region Factory Methods
        public void SetAvatar(IMedia avatar)
        {
            this.Avatar = avatar;
        }
        public void SetAvatar(Guid id, string url)
        {
            IMedia media = _media.Create(id, url, false);

            this.SetAvatar(media);
        }
        #endregion

        #region Properties
        public Guid? NationalityId { get; set; }
        public INationality Nationality { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Guid> SelectedClaims { get; set; }
        public List<Guid> SelectedCategories { get; set; }
        public Guid? ProfileId { get; set; }
        public Guid? PreferenceId { get; set; }
        public Guid? SecurityId { get; set; }
        public Guid? PrivacyId { get; set; }
        public Guid? EducationId { get; set; }
        public IGender Gender { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Social { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string SecurityStamp { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public short? Prefix { get; set; }
        public string Mobile { get; set; } = string.Empty;
        public bool Newsletter { get; set; }
        public bool Claimed { get; set; }
        public bool Online { get; set; }
        public bool Staff { get; set; }
        public DateTime? Birth { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? RefreshTokenExpiration { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public string ConfirmPassword { get; set; } = string.Empty;
        public bool Active { get; set; }
        public int LoginAttempt { get; set; } = 0;
        public bool Highlighted { get; set; }
        public bool Banned { get; set; }
        public bool Verified { get; set; }
        public bool Expired { get; set; }
        public bool Locked { get; set; }
        public DateTime? LockedOn { get; set; }
        public DateTime? BannedOn { get; set; }
        public DateTime? VerifiedOn { get; set; }
        #endregion

        #region Methods
        //public void SetAttributeValues(IAttributeValue attributeValue)
        //{
        //    AttributeValues.Add(attributeValue);
        //}
        public void SetAttributeValues(Guid id, string name, string description)
        {
            //IAttributeValue values = _attributeValue.Create(id, name, description);
            //this.SetAttributeValues(values);
        }
        public void SetAddress(IAddress address)
        {
            Addresses.Add(address);
        }
        public void SetAddress(Guid id, string street, string number, string postcode)
        {
            IAddress address = _address.Create(id, street, number, postcode);

            Addresses.Add(address);
        }
        public void SetSalt(string salt)
        {
            this.Salt = salt;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public void Activate()
        {
            this.Active = true;
        }
        public void Deactivate()
        {
            this.Active = false;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }
        public void SetNationality(string name)
        {
        }
        #endregion
    }
}