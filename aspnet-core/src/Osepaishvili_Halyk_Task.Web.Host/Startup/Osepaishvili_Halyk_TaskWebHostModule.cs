using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Osepaishvili_Halyk_Task.Configuration;

namespace Osepaishvili_Halyk_Task.Web.Host.Startup
{
    [DependsOn(
       typeof(Osepaishvili_Halyk_TaskWebCoreModule))]
    public class Osepaishvili_Halyk_TaskWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Osepaishvili_Halyk_TaskWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Osepaishvili_Halyk_TaskWebHostModule).GetAssembly());
        }
    }
}
