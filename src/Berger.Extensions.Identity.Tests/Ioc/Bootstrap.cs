using Microsoft.EntityFrameworkCore;
using Berger.Extensions.Identity.Services;
using Microsoft.Extensions.DependencyInjection;
using Berger.Extensions.Identity.Interfaces;

namespace Berger.Extensions.Identity.Tests.Ioc
{
    public static class Bootstrap
    {
        public static void Register(this IServiceCollection services)
        {
            // Domain Services
            services.AddScoped<IHashService, HashService>();
            services.AddScoped<ISaltService, SaltService>();

        }
        public static void Register<T>(this IServiceCollection services) where T : DbContext
        {
        }
    }
}