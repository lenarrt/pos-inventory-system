using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class OwnerUsage
    {
        [Key]
        public int UsageId { get; set; }

        public string? Description { get; set; }
        public decimal TotalAmount { get; set; }
        public string? InvoiceNumber { get; set; }

        public DateTime UsageDate { get; set; }

        // Navigation
        public ICollection<OwnerUsageSale>? Items { get; set; }
    }
}
