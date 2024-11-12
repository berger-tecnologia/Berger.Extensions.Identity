using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Account : BaseEntity
    {
        #region Properties
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string SecurityStamp { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
        public int LoginAttempt { get; set; } = 0;
        public bool IsEmailVerified { get; set; }
        public bool Expired { get; } = false;
        public bool Banned { get; set; } = false;
        public bool Locked { get; set; } = false;
        public bool Active { get; set; } = true;
        public DateTime? StartsOn { get; }
        public DateTime? ExpiresOn { get; }
        public DateTime? LastLogin { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? RefreshTokenExpiration { get; set; }
        #endregion

        #region Methods
        //public void SetUserId(Guid userId)
        //{
        //    this.UserId = userId;
        //}
        public void SetSalt(string salt)
        {
            this.Salt = salt;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public void SetHash(string hash)
        {
            this.Hash = hash;
        }
        public void Activate()
        {
            this.Active = true;
        }
        public void Deactivate()
        {
            this.Active = false;
        }
        #endregion
    }
}