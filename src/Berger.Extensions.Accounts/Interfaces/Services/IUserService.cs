namespace Berger.Extensions.Accounts
{
    public interface IUserService
    {
        #region Methods
        bool Login();
        List<User> Get();
        #endregion
    }
}