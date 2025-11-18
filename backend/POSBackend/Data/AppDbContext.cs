using Microsoft.EntityFrameworkCore;
using POSBackend.Data.Models;

namespace POSBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        public DbSet<OwnerUsage> OwnerUsage { get; set; }
        public DbSet<OwnerUsageSale> OwnerUsageSales { get; set; }

        public DbSet<PayLaterSale> PayLaterSales { get; set; }
        public DbSet<PayLaterItem> PayLaterItems { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<LicenseInfo> LicenseInfos { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }
        public DbSet<LaborFeeHistory> LaborFeeHistories { get; set; }
    }
}
