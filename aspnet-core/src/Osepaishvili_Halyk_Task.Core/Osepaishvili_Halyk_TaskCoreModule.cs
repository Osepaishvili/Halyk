using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Osepaishvili_Halyk_Task.Authorization.Roles;
using Osepaishvili_Halyk_Task.Authorization.Users;
using Osepaishvili_Halyk_Task.Configuration;
using Osepaishvili_Halyk_Task.Localization;
using Osepaishvili_Halyk_Task.MultiTenancy;
using Osepaishvili_Halyk_Task.Timing;

namespace Osepaishvili_Halyk_Task
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class Osepaishvili_Halyk_TaskCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            Osepaishvili_Halyk_TaskLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = Osepaishvili_Halyk_TaskConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Osepaishvili_Halyk_TaskCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
