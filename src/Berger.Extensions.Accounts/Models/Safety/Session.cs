using Berger.Extensions.Base;

namespace Berger.Extensions.Accounts
{
    public class Session : BaseEntity, ISecurityStamp, IExpired
    {
        #region Properties
        public Guid? CountryID { get; set; }
        public Guid DeviceID { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string TokenIssuer { get; set; }
        public string TokenAudience { get; set; }
        public string SecurityStamp { get; set; }
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public bool Expired { get; set; }
        public bool Revoked { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public DateTime? LastUsedOn { get; set; }
        public DateTime? RevokedOn { get; set; }
        #endregion

        #region Methods
        public void Revoke()
        {
            this.Revoked = true;
            this.RevokedOn = DateTime.UtcNow;
        }
        public void SetLastUsed()
        {
            this.LastUsedOn = DateTime.UtcNow;
        }
        public void SetDeviceId(Guid id)
        {
            this.DeviceID = id;
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
    }
}