using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserBase : UserInput, IVerified, IActivated
    {
        #region Properties
        public List<Account> Accounts { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<UserClaim> UserClaims { get; set; }
        #endregion

        #region Factories
        private readonly IMediaFactory _mediaFactory;
        private readonly IAddressFactory _addressFactory;
        #endregion

        #region Constructors
        public UserBase()
        {
        }
        public UserBase(IAddressFactory addressFactory, IMediaFactory mediaFactory)
        {
            _mediaFactory = mediaFactory;
            _addressFactory = addressFactory;
        }
        #endregion

        #region Factories
        public IMedia Avatar { get; set; }
        public List<IMedia> Medias { get; set; } = new List<IMedia>();
        public List<IAddress> Addresses { get; set; } = new List<IAddress>();
        #endregion

        #region Methods
        public void SetAvatar(Guid id, string url)
        {
            IMedia media = _mediaFactory.Create(id, url, false);

            this.SetAvatar(media);
        }
        public void SetAvatar(IMedia avatar)
        {
            this.Avatar = avatar;
        }
        #endregion

        #region Methods
        public void SetAddress(IAddress address)
        {
            Addresses.Add(address);
        }
        public void SetAddress(Guid id, string street, string number, string postcode)
        {
            IAddress address = _addressFactory.Create(id, street, number, postcode);

            Addresses.Add(address);
        }
        #endregion
    }
}