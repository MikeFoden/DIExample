using System;

namespace DIExample.Library.Data.Infrastructure
{
    #region Interface
    public interface IDbFactory : IDisposable
    {
        DIExampleDbContext Init();
    }
    #endregion Interface

    public class DbFactory : Disposable, IDbFactory
    {
        DIExampleDbContext dbContext;

        public DIExampleDbContext Init()
        {
            return dbContext ?? (dbContext = new DIExampleDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
