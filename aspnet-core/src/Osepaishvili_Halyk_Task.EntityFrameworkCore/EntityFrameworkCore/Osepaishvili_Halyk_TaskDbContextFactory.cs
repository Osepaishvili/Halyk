using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Osepaishvili_Halyk_Task.Configuration;
using Osepaishvili_Halyk_Task.Web;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Osepaishvili_Halyk_TaskDbContextFactory : IDesignTimeDbContextFactory<Osepaishvili_Halyk_TaskDbContext>
    {
        public Osepaishvili_Halyk_TaskDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Osepaishvili_Halyk_TaskDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Osepaishvili_Halyk_TaskDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Osepaishvili_Halyk_TaskConsts.ConnectionStringName));

            return new Osepaishvili_Halyk_TaskDbContext(builder.Options);
        }
    }
}
