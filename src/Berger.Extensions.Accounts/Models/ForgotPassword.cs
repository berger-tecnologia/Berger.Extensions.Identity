using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class ForgotPassword : BaseEntity, IInput
    {
        public string Email { get; set; } = string.Empty;
    }
}