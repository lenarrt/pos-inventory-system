using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class PayLaterItem
    {
        [Key]
        public int PayLaterItemId { get; set; }

        public int PayLaterId { get; set; }
        public PayLaterSale? PayLaterSale { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal TotalValue { get; set; }
    }
}
