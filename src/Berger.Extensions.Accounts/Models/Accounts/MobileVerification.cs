namespace Berger.Extensions.Accounts
{
    public record MobileVerification 
    {
        public string Code { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}