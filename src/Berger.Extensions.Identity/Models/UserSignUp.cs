namespace Berger.Extensions.Identity
{
    public class UserSignUp : UserSignIn
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
    }
}