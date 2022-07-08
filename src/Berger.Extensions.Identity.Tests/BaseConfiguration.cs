using System;
using Berger.Extensions.Common.Config;
using Microsoft.Extensions.Configuration;
using Berger.Extensions.Identity.Tests.Ioc;
using Berger.Extensions.Repository.Auxiliar;
using Berger.Extensions.Identity.Tests.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Identity.Tests
{
    public abstract class BaseConfiguration : IDisposable
    {
        #region Properties
        public static IConfiguration Configuration { get; }
        #endregion

        #region Methods
        public void Configure()
        {
            CreateDatabase();
        }

        protected void Initialize()
        {
        }

        protected void Cleanup()
        {
            DestroyDatabase();
        }
        private void DestroyDatabase()
        {
        }
        private void CreateDatabase()
        {
            var provider = CreateProvider();

            var _context = GetInstance<UnitTestContext>(provider);

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }
        public static IServiceProvider CreateProvider()
        {
            // Config File
            var builder = Configuration.SetConfig().Build();

            // Service Configuration
            IServiceCollection services = new ServiceCollection();

            // Dependencies
            services.Register();
            services.Register<UnitTestContext>();

            // SQL Server dependencies
            services.ConfigureSql<UnitTestContext>(builder, "AzureSqlServer");

            //services.AddOptions();

            // Service Building
            return services.BuildServiceProvider();
        }
        public T GetInstance<T>(IServiceProvider provider)
        {
            return provider.GetService<T>();
        }

        public abstract void Dispose();
        #endregion
    }
}