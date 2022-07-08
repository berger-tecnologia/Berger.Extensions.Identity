using System.Text;
using Berger.Extensions.Identity.Interfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Berger.Extensions.Identity.Services
{
    public class HashService : IHashService
    {
        public string Create(string password, string salt)
        {
            var bytes = KeyDerivation.Pbkdf2
                (
                    password: password, 
                    salt: Encoding.UTF8.GetBytes(salt), 
                    prf: KeyDerivationPrf.HMACSHA512, 
                    iterationCount: 10000, 
                    numBytesRequested: 256 / 8
                );

            return Convert.ToBase64String(bytes);
        }

        public bool Validate(string password, string salt, string hash) => Create(password, salt) == hash;
    }
}