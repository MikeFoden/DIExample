using System;

namespace DIExample.Library.Models
{
    public class Product : BaseModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }

        // In a real-world use case, categories would get their own table.
        public string CategoryName { get; set; }

        public Product()
        {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
    }
}
