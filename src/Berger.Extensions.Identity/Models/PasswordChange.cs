namespace Berger.Extensions.Identity
{
    public record PasswordChange
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}