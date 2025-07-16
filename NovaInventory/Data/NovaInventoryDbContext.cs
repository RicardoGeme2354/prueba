using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<NovaInventory.Models.Entities.Client> Clients { get; set; } = default!;
        public DbSet<NovaInventory.Models.Entities.Product> Products { get; set; } = default!;
        public DbSet<NovaInventory.Models.Entities.Order> Orders { get; set; } = default!;
    }
}