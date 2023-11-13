using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public interface IUserService : IService<User>
    {
        #region Methods
        bool Login();
        #endregion
    }
}