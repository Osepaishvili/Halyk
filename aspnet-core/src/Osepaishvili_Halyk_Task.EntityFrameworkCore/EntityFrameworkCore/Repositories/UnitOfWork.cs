using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore.Repositories
{
    public class CustomUnitOfWork : ICustomUnitOfWork
    {
        private readonly Osepaishvili_Halyk_TaskDbContext _context = new Osepaishvili_Halyk_TaskDbContext(new DbContextOptions<Osepaishvili_Halyk_TaskDbContext>());



        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
