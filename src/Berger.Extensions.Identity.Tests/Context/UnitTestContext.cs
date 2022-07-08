using Microsoft.EntityFrameworkCore;

namespace Berger.Extensions.Identity.Tests.Context
{
    public sealed class UnitTestContext : DbContext
    {
        public UnitTestContext(DbContextOptions<UnitTestContext> options) : base(options)
        {
            Database.SetCommandTimeout(300000);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}