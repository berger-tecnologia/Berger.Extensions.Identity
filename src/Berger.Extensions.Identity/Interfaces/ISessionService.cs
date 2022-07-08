namespace Berger.Extensions.Identity.Interfaces
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