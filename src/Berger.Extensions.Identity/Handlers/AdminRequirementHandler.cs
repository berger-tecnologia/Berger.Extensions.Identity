using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Berger.Extensions.Identity.Requirements;

namespace Berger.Extensions.Identity.Handlers
{
    public class AdminRequirementHandler : AuthorizationHandler<AdminRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AdminRequirement requirement)
        {
            if (!context.User.HasClaim(x => x.Type == ClaimTypes.Role))
                return Task.CompletedTask;

            var claim = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role);
            var role = claim.Value;

            if (role == "admin")
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}