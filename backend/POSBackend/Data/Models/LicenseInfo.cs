using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class LicenseInfo
    {
        [Key]
        public int LicenseId { get; set; }

        public string? MachineId { get; set; }  // unique identifier
        public string? LicenseKey { get; set; }
        public DateTime ActivatedOn { get; set; }
    }
}
