using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        public string? CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal LaborFee { get; set; }
        public decimal Discount { get; set; }

        public string? PaymentMethod { get; set; }
        public DateTime SaleDate { get; set; }

        // Navigation
        public ICollection<SaleItem>? Items { get; set; }
    }
}
