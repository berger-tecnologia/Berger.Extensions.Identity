using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Otp : BaseEntity, IInput
    {
        public string Email { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string[] Codes { get; set; } = new string[5];
    }
}