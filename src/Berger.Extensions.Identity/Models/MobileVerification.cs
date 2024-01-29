namespace Berger.Extensions.Identity
{
    public record MobileVerification 
    {
        public string Code { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}