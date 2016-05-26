using DIExample.Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Library.Data
{
    public class SeedData : DropCreateDatabaseIfModelChanges<DIExampleDbContext>
    {
        protected override void Seed(DIExampleDbContext context)
        {
            // This is where you would seed default products
            PrepareDefaultProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Product> PrepareDefaultProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductName = "Apple",
                    CategoryName = "Fruit",
                    StockCount = 10,
                    Price = 1.50M
                },
                new Product
                {
                    ProductName = "Banana",
                    CategoryName = "Fruit",
                    StockCount = 20,
                    Price = 0.50M
                },
                new Product
                {
                    ProductName = "2L Milk",
                    CategoryName = "Drinks",
                    StockCount = 5,
                    Price = 2.50M
                }
                ,
                new Product
                {
                    ProductName = "Bread Loaf",
                    CategoryName = "Bread",
                    StockCount = 50,
                    Price = 3.50M
                }
            };
        }
    }
}
