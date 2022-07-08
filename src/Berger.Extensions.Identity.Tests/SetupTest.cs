using NUnit.Framework;

namespace Berger.Extensions.Identity.Tests
{
    [Order(1)]
    public class SetupTests : BaseConfiguration
    {
        public override void Dispose() => Cleanup();

        [Test]
        [Order(1)]
        public void ShouldConfigure()
        {
            Configure();
        }
    }
}