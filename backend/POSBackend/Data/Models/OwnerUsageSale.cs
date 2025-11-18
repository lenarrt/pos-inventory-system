using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class OwnerUsageSale
    {
        [Key]
        public int UsageItemId { get; set; }

        public int UsageId { get; set; }
        public OwnerUsage? OwnerUsage { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal TotalValue { get; set; }
    }
}
