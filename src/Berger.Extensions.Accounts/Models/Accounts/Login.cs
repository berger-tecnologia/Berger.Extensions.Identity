namespace Berger.Extensions.Accounts
{
    public class Login
    {
        public bool RememberMe { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}