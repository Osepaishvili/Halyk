using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Osepaishvili_Halyk_Task.Configuration;
using Osepaishvili_Halyk_Task.EntityFrameworkCore;
using Osepaishvili_Halyk_Task.Migrator.DependencyInjection;

namespace Osepaishvili_Halyk_Task.Migrator
{
    [DependsOn(typeof(Osepaishvili_Halyk_TaskEntityFrameworkModule))]
    public class Osepaishvili_Halyk_TaskMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Osepaishvili_Halyk_TaskMigratorModule(Osepaishvili_Halyk_TaskEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Osepaishvili_Halyk_TaskMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Osepaishvili_Halyk_TaskConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Osepaishvili_Halyk_TaskMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
