using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string? Username { get; set; }
        public string? PasswordHash { get; set; }   // storing hash, not plain text!
        public string? Role { get; set; }          // admin, employee, owner

        public DateTime CreatedAt { get; set; }
    }
}
