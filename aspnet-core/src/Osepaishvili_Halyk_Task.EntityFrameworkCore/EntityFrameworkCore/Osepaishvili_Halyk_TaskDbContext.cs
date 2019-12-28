using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Osepaishvili_Halyk_Task.Authorization.Roles;
using Osepaishvili_Halyk_Task.Authorization.Users;
using Osepaishvili_Halyk_Task.MultiTenancy;
using Osepaishvili_Halyk_Task.EntityFrameworkCore.Entities;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore
{
    public class Osepaishvili_Halyk_TaskDbContext : AbpZeroDbContext<Tenant, Role, User, Osepaishvili_Halyk_TaskDbContext>
    {
        /* Define a DbSet for each entity of the application */
        DbSet<Employee> Employees { get; set; }

        public Osepaishvili_Halyk_TaskDbContext(DbContextOptions<Osepaishvili_Halyk_TaskDbContext> options)
            : base(options)
        {
        }

    }
}
