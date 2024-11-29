using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class UserSignIn : BaseEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; } = true;
        public string ReturnUrl { get; set; }
        public string Token { get; set; }
    }
}