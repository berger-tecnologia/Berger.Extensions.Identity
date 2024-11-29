using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class Otp : BaseEntity
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string[] Codes { get; set; } = new string[5];
    }
}