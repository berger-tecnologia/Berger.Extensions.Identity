using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Session : BaseEntity
    {
        #region Methods
        public void Revoke()
        {
            this.Revoked = true;
            this.RevokedOn = DateTime.UtcNow;
        }
        public void SetAccountId(Guid accountId)
        {
            this.AccountId = accountId;
        }
        public void SetApplicationId(Guid applicationId)
        {
            this.ApplicationId = applicationId;
        }
        public void SetLastUsed()
        {
            this.LastUsedOn = DateTime.UtcNow;
        }
        public void SetToken(string token)
        {
            this.Token = token;
        }
        public void SetRefreshToken(string refresh)
        {
            this.RefreshToken = refresh;
        }
        public void SetStartsOn(DateTime starts)
        {
            this.StartsOn = starts;
        }
        public void SetExpiresOn(DateTime expires)
        {
            this.ExpiresOn = expires;
        }
        public void SetLastUsedOn(DateTime lastUsed)
        {
            this.LastUsedOn = lastUsed;
        }
        public void SetIp(string ip)
        {
            this.IpAddress = ip;
        }
        #endregion

        #region Properties
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid? DeviceId { get; }
        public Guid? CountryId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string TokenIssuer { get; set; }
        public string TokenAudience { get; set; }
        public string SecurityStamp { get; set; }
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public bool Expired { get; set; }
        public bool Revoked { get; set; } = false;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public DateTime? LastUsedOn { get; set; }
        public DateTime? RevokedOn { get; set; }
        #endregion
    }
}