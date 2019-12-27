using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Osepaishvili_Halyk_Task.Authorization;
using Osepaishvili_Halyk_Task.Authorization.Roles;
using Osepaishvili_Halyk_Task.Authorization.Users;
using Osepaishvili_Halyk_Task.Editions;
using Osepaishvili_Halyk_Task.MultiTenancy;

namespace Osepaishvili_Halyk_Task.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
