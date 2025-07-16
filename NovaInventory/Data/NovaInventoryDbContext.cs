using Microsoft.EntityFrameworkCore;
using NovaInventory.Models.Entities;

namespace NovaInventory.Data
{  

    public class NovaInventoryDbContext : DbContext
    {
        public NovaInventoryDbContext(DbContextOptions<NovaInventoryDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
    }
}