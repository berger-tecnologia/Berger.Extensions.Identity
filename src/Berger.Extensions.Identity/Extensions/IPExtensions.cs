using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Berger.Extensions.Identity.Extensions
{
    public static class IPExtensions
    {
        public static string GetIp(this HttpContext context)
        {
            var address = context.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress;

            if (context != null)
                return context.ToString();
            else
                return string.Empty;
        }
    }
}