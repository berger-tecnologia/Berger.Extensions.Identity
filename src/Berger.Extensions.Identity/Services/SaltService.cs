using System.Security.Cryptography;
using Berger.Extensions.Identity.Interfaces;

namespace Berger.Extensions.Identity.Services
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