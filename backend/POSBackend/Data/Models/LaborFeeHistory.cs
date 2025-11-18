using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class LaborFeeHistory
    {
        [Key]
        public int LaborFeeId { get; set; }

        public decimal FeeAmount { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
