namespace Berger.Extensions.Accounts
{
    internal class Credential
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