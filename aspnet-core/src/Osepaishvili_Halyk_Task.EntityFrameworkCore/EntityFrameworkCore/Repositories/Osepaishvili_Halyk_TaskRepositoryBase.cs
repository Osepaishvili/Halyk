using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace Osepaishvili_Halyk_Task.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class Osepaishvili_Halyk_TaskRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<Osepaishvili_Halyk_TaskDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Osepaishvili_Halyk_TaskRepositoryBase(IDbContextProvider<Osepaishvili_Halyk_TaskDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="Osepaishvili_Halyk_TaskRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class Osepaishvili_Halyk_TaskRepositoryBase<TEntity> : Osepaishvili_Halyk_TaskRepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        protected Osepaishvili_Halyk_TaskRepositoryBase(IDbContextProvider<Osepaishvili_Halyk_TaskDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
