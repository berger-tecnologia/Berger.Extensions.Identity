using NUnit.Framework;
using Berger.Extensions.Identity.Interfaces;

namespace Berger.Extensions.Identity.Tests.Unity
{
    public class HashTest : BaseConfiguration
    {
        public override void Dispose() => Cleanup();

        [Test]
        [Order(0)]
        public void NeedToMatch()
        {
            var provider = CreateProvider();

            var _hash = GetInstance<IHashService>(provider);
            var _salt = GetInstance<ISaltService>(provider);

            var password = "p@ssw0rd";
            
            var salt = _salt.Create();
            var hash = _hash.Create(password, salt);
            var match = _hash.Validate(password, salt, hash);

            Assert.IsTrue(match);
        }

        [Test]
        [Order(1)]
        public void NeedToMatchWithSalt()
        {
            var provider = CreateProvider();

            var _hash = GetInstance<IHashService>(provider);

            var password = "p@ssw0rd";
            var salt = "sEA17MQ6s7xwqJUUE8SG6g==";

            var hash = _hash.Create(password, salt);

            Assert.IsTrue(hash == "c2KcUkDkfdB6dfAYlnldpb/OH/FqgaZ4F2mR9trodAw=");
        }

        [Test]
        [Order(2)]
        public void DoesNotNeedToMatch()
        {
            var provider = CreateProvider();

            var _hash = GetInstance<IHashService>(provider);
            var _salt = GetInstance<ISaltService>(provider);

            var password = "mysecretpassword";
            var hash = "invalidhash";

            var salt = _salt.Create();

            var match = _hash.Validate(password, salt, hash);

            Assert.IsFalse(match);
        }

        [Test]
        [Order(3)]
        public void DoesNotNeedToMatchTwoPassawords()
        {
            var provider = CreateProvider();

            var _hash = GetInstance<IHashService>(provider);
            var _salt = GetInstance<ISaltService>(provider);

            var password_1 = "mysecretpassword_1";
            var password_2 = "mysecretpassword_2";

            var salt = _salt.Create();

            var hash_1 = _hash.Create(password_1, salt);
            var hash_2 = _hash.Create(password_2, salt);

            Assert.IsTrue(hash_1 != hash_2);
        }
    }
}