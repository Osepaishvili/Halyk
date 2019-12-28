using Osepaishvili_Halyk_Task.EntityFrameworkCore.Entities;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore.Repositories
{
    public class EmployeeRepo : GenericRepository<Employee>
    {
        public EmployeeRepo(Osepaishvili_Halyk_TaskDbContext context) : base(context)
        {
        }
    }
}
