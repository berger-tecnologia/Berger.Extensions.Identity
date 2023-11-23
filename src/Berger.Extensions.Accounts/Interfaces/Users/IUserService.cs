namespace Berger.Extensions.Accounts
{
    public interface IUserService
    {
        User GetById(Guid id);
        IQueryable<User> Get();
    }
}