using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Session : BaseEntity
    {
        #region Methods
        public void Revoke()
        {
            this.Revoked = true;
            this.RevokedOn = DateTime.UtcNow;
        }
        public void SetUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
        public void SetDeviceId(Guid deviceId)
        {
            throw new NotImplementedException();
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
        public Guid DeviceId { get; }
        public Guid? CountryId { get; set; }
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public string TokenIssuer { get; set; } = string.Empty;
        public string TokenAudience { get; set; } = string.Empty;
        public string SecurityStamp { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public bool Expired { get; set; }
        public bool Revoked { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public DateTime? LastUsedOn { get; set; }
        public DateTime? RevokedOn { get; set; }
        #endregion
    }
}