using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore
{
    public static class Osepaishvili_Halyk_TaskDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Osepaishvili_Halyk_TaskDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Osepaishvili_Halyk_TaskDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
