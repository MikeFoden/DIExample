using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DIExample.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, 99999999)]
        [DisplayName("Price ($)")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 99999)]
        [DisplayName("Stock Count")]
        public int StockCount { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

    }
}