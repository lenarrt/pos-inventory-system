using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSBackend.Data.Models
{
    public class SaleItem
    {
        [Key]
        public int SaleItemId { get; set; }

        public int SaleId { get; set; }
        public Sale? Sale { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalValue { get; set; }
    }
}
