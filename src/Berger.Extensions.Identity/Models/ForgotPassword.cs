using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Identity
{
    public class ForgotPassword : BaseEntity
    {
        public string Email { get; set; }
    }
}