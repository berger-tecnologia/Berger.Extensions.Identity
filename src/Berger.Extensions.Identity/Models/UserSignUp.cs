namespace Berger.Extensions.Identity
{
    public class UserSignUp : UserSignIn
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Document { get; set; }
    }
}