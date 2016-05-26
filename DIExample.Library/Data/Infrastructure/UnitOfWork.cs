using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Library.Data.Infrastructure
{
    #region Interface
    public interface IUnitOfWork
    {
        void Commit();
    }
    #endregion Interface

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DIExampleDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DIExampleDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }

}
