using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class UserSignIn : BaseEntity, IInput
    {
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public bool RememberMe { get; set; } = true;
        public string ReturnUrl { get; set; } = string.Empty;
    }
}