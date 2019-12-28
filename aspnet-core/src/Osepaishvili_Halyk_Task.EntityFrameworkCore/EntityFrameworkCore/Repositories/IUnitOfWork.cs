using System;
using System.Collections.Generic;
using System.Text;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore.Repositories
{
    public interface ICustomUnitOfWork : IDisposable
    {

        EmployeeRepo EmployeeRepo { get; }
        void Save();

    }
}
