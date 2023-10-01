namespace Berger.Extensions.Accounts
{
    public class User
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Active { get; set; }
        #endregion

        #region Methods
        public void Deactivate()
        {
            this.Active = false;
        }
        #endregion
    }
}