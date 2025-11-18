using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class PayLaterSale
    {
        [Key]
        public int PayLaterId { get; set; }

        public string? CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }

        // When the customer finally pays
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }

        public ICollection<PayLaterItem>? Items { get; set; }
    }
}
