using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class User : BaseEntity, IVerified, IActivated
    {
        #region Factories
        private readonly IMediaFactory _mediaFactory;
        private readonly IAddressFactory _addressFactory;
        #endregion

        #region Constructors
        public User()
        {
        }
        public User(IAddressFactory addressFactory, IMediaFactory mediaFactory)
        {
            _mediaFactory = mediaFactory;
            _addressFactory = addressFactory;
        }
        #endregion

        #region Properties
        public Guid? NationalityId { get; set; }
        public INationality Nationality { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Mobile { get; set; }
        public List<Guid> SelectedClaims { get; set; }
        public List<Guid> SelectedCategories { get; set; }
        public Guid? ProfileId { get; set; }
        public Guid? PreferenceId { get; set; }
        public Guid? SecurityId { get; set; }
        public Guid? PrivacyId { get; set; }
        public Guid? EducationId { get; set; }
        //public IGender Gender { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Social { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string SecurityStamp { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
        public string Sub { get; set; } = string.Empty;
        public string Torre { get; set; } = string.Empty;
        public string Apartamento { get; set; } = string.Empty;
        public string Bloco { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public short? Prefix { get; set; }
        public bool Newsletter { get; set; }
        public bool Claimed { get; set; }
        public bool Online { get; set; }
        public bool Staff { get; set; }
        public DateTime? Birthday { get; set; }
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
        public List<UserRole> UserRoles { get; set; }
        public List<UserClaim> UserClaims { get; set; }

        #endregion

        #region Factories
        public IMedia Avatar { get; set; }
        public List<IMedia> Medias { get; set; } = new List<IMedia>();
        public List<IAddress> Addresses { get; set; } = new List<IAddress>();
        #endregion

        #region Factory Methods
        public void SetAvatar(IMedia avatar)
        {
            this.Avatar = avatar;
        }
        public void SetAvatar(Guid id, string url)
        {
            IMedia media = _mediaFactory.Create(id, url, false);

            this.SetAvatar(media);
        }
        #endregion

        #region Methods
        public void SetAttributeValues(Guid id, string name, string description)
        {
            //throw new NotImplementedException();
        }
        public void SetAddress(IAddress address)
        {
            Addresses.Add(address);
        }
        public void SetAddress(Guid id, string street, string number, string postcode)
        {
            IAddress address = _addressFactory.Create(id, street, number, postcode);

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
            // throw new NotImplementedException();
        }
        #endregion
    }
}