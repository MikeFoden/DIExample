using DIExample.Library.Data.Infrastructure;
using DIExample.Library.Models;
using System;

namespace DIExample.Library.Data.Repository
{
    #region Interface
    public interface IProductRepository : IRepository<Product>
    {
    }
    #endregion Interface

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory)
        { }


        public override void Update(Product entity)
        {
            // Let's keep the entity's latest updated date set
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }
}
