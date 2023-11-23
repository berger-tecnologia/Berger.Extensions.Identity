namespace Berger.Extensions.Accounts
{
    public interface IAccount
    {
        public void Logoff();
        bool SignUp(UserSignUp model);
        string Signin(UserSignIn model);
        bool Forgot(MobileVerification model);
        bool Otp(Otp model);
        bool ChangePasseword(PasswordChange change);
    }
}