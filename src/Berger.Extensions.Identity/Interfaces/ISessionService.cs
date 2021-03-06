namespace Berger.Extensions.Identity
{
    public interface ISessionService
    {
        void Logoff();
        Guid GetSid();
        string GetIp();
        string GetName();
        Guid GetGroupSid();
        string GetEmail();
    }
}