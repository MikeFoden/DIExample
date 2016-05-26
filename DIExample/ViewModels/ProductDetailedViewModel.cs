using System;

namespace DIExample.ViewModels
{
    public class ProductDetailedViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public string CategoryName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}