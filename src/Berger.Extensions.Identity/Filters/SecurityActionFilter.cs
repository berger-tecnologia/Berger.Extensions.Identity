using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Identity
{
    public class SecurityActionFilter : ActionFilterAttribute
    {
        #region Properties
        public ISessionService _session;
        #endregion

        #region Constructors
        public SecurityActionFilter()
        {
        }
        #endregion

        #region Events
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _session = context.HttpContext.RequestServices.GetService<ISessionService>();

            var ip = _session.GetIp();
            var name = _session.GetName();
            var userID = _session.GetSid();

            Controller controller = context.Controller as Controller;

            controller.ViewData["Name"] = name;
            controller.ViewData["IpAddress"] = ip;
            controller.ViewData["UserID"] = userID;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
        }
        #endregion
    }
}