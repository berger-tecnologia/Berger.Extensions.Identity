namespace Berger.Extensions.Accounts
{
    public class Credential
    {
        #region Properties
        public CredentialType CredentialType { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Expired { get; }
        public DateTime? StartsOn { get; }
        public DateTime? ExpiresOn { get; }
        #endregion
    }
}