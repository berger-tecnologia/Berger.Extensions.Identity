namespace Berger.Extensions.Accounts
{
    public interface ISession
    {
        #region Properties
        public Guid? SessionID { get; }
        #endregion

        #region Methods
        public void SetSessionId(Guid id);
        #endregion
    }
}