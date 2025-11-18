using System.ComponentModel.DataAnnotations;

namespace POSBackend.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Brand { get; set; }
        public string? Type { get; set; }
        public string? Unit { get; set; }
        public int QuantityInStock { get; set; }
        public int MinStockAlert { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Discount { get; set; }
        public string? Barcode { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
