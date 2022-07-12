using System.Security.Cryptography;

namespace Berger.Extensions.Identity
{
    public class SaltService : ISaltService
    {
        public string Create()
        {
            byte[] random = new byte[128 / 8];

            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(random);
                
                return Convert.ToBase64String(random);
            }
        }
    }
}