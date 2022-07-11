using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;
using Berger.Extensions.Identity.Requirements;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Berger.Extensions.Identity.Extensions
{
    public static class AccessControlExtenssions
    {
        public static void ConfigureJwt(this IServiceCollection services, string issuer, string secret)
        {
            var encoded = Encoding.ASCII.GetBytes(secret);

            services.AddAuthentication
            (
                x =>
                {
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x => {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = issuer,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(encoded),
                    };
                }
            );
        }

        public static void ConfigureAuthentication(this IApplicationBuilder app)
        {
            app.UseCookiePolicy();

            app.Use(async (context, next) =>
            {
                var token = context.Session.GetString("Token");

                if (!string.IsNullOrEmpty(token))
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + token);
                }
                await next();
            });

            app.UseAuthentication();
        }

        public static void SetPolicies(this IServiceCollection services)
        {
            services.AddAuthorization
            (
                config =>
                {
                    config.AddPolicy("ShouldBeAdmin", options =>
                    {
                        options.RequireAuthenticatedUser();
                        options.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
                        options.Requirements.Add(new AdminRequirement());
                    });

                    //config.AddPolicy("ShouldContainRole", options => options.RequireClaim(ClaimTypes.Role));
                });
        }

        public static void ConfigureAuthorization(this IApplicationBuilder app)
        {
            app.UseAuthorization();
        }
    }
}