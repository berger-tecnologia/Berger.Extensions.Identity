using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Berger.Extensions.Identity.Interfaces;

namespace Berger.Extensions.Identity.Services
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _acessor;

        public SessionService(IHttpContextAccessor acessor)
        {
            //this._audit = audit;
            this._acessor = acessor ?? throw new ArgumentNullException(nameof(acessor));
        }

        public Guid GetGroupSid()
        {
            var claim = _acessor.HttpContext.User.FindFirst(ClaimTypes.GroupSid);

            return Guid.Parse(claim.Value);
        }

        public Guid GetSid()
        {
            var claim = _acessor.HttpContext.User.FindFirst(ClaimTypes.Sid);

            return Guid.Parse(claim.Value);
        }
        public string GetName()
        {
            var claim = _acessor.HttpContext.User.FindFirst(ClaimTypes.Name);

            return claim != null ? claim.Value : string.Empty;
        }
        public string GetEmail()
        {
            var claim = _acessor.HttpContext.User.FindFirst(ClaimTypes.Email);

            return claim != null ? claim.Value : string.Empty;
        }
        public string GetIp()
        {
            var address = _acessor.HttpContext.Features.Get<IHttpConnectionFeature>();

            if (address != null)
                return address.RemoteIpAddress.ToString();
            else
                return string.Empty;
        }
        public void Logoff()
        {
            var ip = GetIp();
            var userID = GetSid();

            //_audit.AuditLogoff(userID, ip);

            _acessor.HttpContext.Session.Remove("Token");
        }
    }
}