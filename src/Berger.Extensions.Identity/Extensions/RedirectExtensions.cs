using System.Net;
using Microsoft.AspNetCore.Builder;

namespace Berger.Extensions.Identity.Extensions
{
    public static class RedirectExtensions
    {
        public static void ConfigureRedirect(this IApplicationBuilder app)
        {
            app.UseStatusCodePages
            (
                async context =>
                {
                    var response = context.HttpContext.Response;

                    if (response.StatusCode == (int)HttpStatusCode.Unauthorized || response.StatusCode == (int)HttpStatusCode.Forbidden)
                        response.Redirect("/account/signin");

                    if (response.StatusCode == (int)HttpStatusCode.NotFound)
                        response.Redirect("/notfound");
                }
            );
        }
    }
}