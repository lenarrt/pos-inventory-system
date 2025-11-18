using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class TransactionLog
    {
        [Key]
        public int LogId { get; set; }

        public string? Action { get; set; }
        public string? PerformedBy { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
