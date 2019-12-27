using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Osepaishvili_Halyk_Task.EntityFrameworkCore.Seed;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore
{
    [DependsOn(
        typeof(Osepaishvili_Halyk_TaskCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Osepaishvili_Halyk_TaskEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Osepaishvili_Halyk_TaskDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        Osepaishvili_Halyk_TaskDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        Osepaishvili_Halyk_TaskDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Osepaishvili_Halyk_TaskEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
