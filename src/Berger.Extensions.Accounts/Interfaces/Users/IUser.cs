namespace Berger.Extensions.Accounts
{
    public interface IUser
    {
        public Guid UserID { get; }
        public User User { get; }
    }
}