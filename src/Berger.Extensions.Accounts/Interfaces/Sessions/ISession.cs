namespace Berger.Extensions.Accounts
{
    public interface ISession
    {
        public Guid? SessionID { get; }
        public void SetSessionId(Guid id);
    }
}