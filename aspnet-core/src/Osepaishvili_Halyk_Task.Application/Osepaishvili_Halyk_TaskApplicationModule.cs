using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Osepaishvili_Halyk_Task.Authorization;

namespace Osepaishvili_Halyk_Task
{
    [DependsOn(
        typeof(Osepaishvili_Halyk_TaskCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Osepaishvili_Halyk_TaskApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Osepaishvili_Halyk_TaskAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Osepaishvili_Halyk_TaskApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
