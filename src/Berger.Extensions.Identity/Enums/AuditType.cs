using System.ComponentModel.DataAnnotations;

namespace Berger.Extensions.Identity
{
    public enum AuditType
    {
        [Display(Name = "Login", Description = "Login")]
        Login = 1,

        [Display(Name = "Logoff", Description = "Logoff")]
        Logoff = 2,

        [Display(Name = "Inactivity", Description = "Inactivity")]
        Inactivity = 3
    }
}