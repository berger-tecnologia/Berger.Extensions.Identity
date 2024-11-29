namespace Berger.Extensions.Identity
{
    public record MobileVerification 
    {
        public string Code { get; set; }
        public string PhoneNumber { get; set; }
    }
}