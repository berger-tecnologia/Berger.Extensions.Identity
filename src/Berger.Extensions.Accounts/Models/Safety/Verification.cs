namespace Berger.Extensions.Accounts
{
    public class Verification
    {
        #region Properties
        public ChannelType ChannelType { get; set; }
        public Guid? PhoneId { get; set; }
        public string Code { get; set; } = string.Empty;
        public bool Verified { get; set; }
        public bool Expired { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public DateTime? VerifiedOn { get; set; }
        #endregion

        #region Methods
        public void Verify()
        {
            this.Verified = true;
            this.VerifiedOn = DateTime.UtcNow;
        }
        public void SetAsExpired()
        {
            this.Expired = true;
        }
        public void SetCode()
        {
            this.Code = GenerateCode();
        }
        public void SetChannelType(ChannelType channelType)
        {
            this.ChannelType = channelType;
        }
        public void SetStartsOn(DateTime starts)
        {
            this.StartsOn = starts;
        }
        public void SetExpiresOn(DateTime expires)
        {
            this.ExpiresOn = expires;
        }
        public void SetPhoneId(Guid id)
        {
            this.PhoneId = id;
        }
        private string GenerateCode()
        {
            return new Random().Next(0, 1000000).ToString("D6");
        }
        #endregion
    }
}