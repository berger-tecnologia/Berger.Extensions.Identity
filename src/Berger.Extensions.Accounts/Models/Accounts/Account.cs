using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Account : BaseEntity
    {
        #region Properties
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Mobile { get; set; }
        public string PasswordHash { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsMobileVerified { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string SecurityStamp { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
        public int LoginAttempt { get; set; } = 0;
        public bool Banned { get; set; }
        public bool Locked { get; set; }
        public bool Expired { get; set; }
        public bool Active { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? RefreshTokenExpiration { get; set; }
        #endregion

        #region Methods
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
        public void SetNationality(string name)
        {
            // throw new NotImplementedException();
        }
        #endregion
    }
}