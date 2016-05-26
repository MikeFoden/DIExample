using DIExample.Library.Models;
using System.Data.Entity.ModelConfiguration;

namespace DIExample.Library.Data
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            Property(p => p.ProductID).IsRequired();
            Property(p => p.ProductName).IsRequired().HasMaxLength(100);
            Property(p => p.Price).IsRequired().HasPrecision(8, 2);
            Property(p => p.StockCount).IsRequired();
            Property(p => p.CategoryName).IsRequired();
        }
    }
}
