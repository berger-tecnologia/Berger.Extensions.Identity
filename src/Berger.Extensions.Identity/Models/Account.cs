using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Account : BaseEntity
    {
        #region Properties
        //public Guid? ProfileId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? MerchantId { get; set; } // Temp..
        public AccountType AccountType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
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