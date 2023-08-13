namespace Berger.Extensions.Accounts
{
    public class Credential
    {
        #region Properties
        public CredentialType CredentialType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Expired { get; }
        public DateTime? StartsOn { get; }
        public DateTime? ExpiresOn { get; }
        #endregion
    }
}