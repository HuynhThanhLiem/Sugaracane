using Microsoft.EntityFrameworkCore;
using SugarcaneApplication.Models;

namespace SugarcaneApplication.Data
{
    public class SugarcaneApplicationDbContext : DbContext
    {
        public SugarcaneApplicationDbContext(DbContextOptions<SugarcaneApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProcessingOrder> ProcessingOrders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
