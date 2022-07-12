using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Identity
{
    public static class IocExtensions
    {
        public static void RegisterSession(this IServiceCollection services)
        {
            services.AddScoped<ISessionService, SessionService>();
        }
    }
}