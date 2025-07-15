using Microsoft.EntityFrameworkCore;
using Singular.Products.Sales.Domain.Entities;

namespace Singular.Products.Sales.Infrastructure.Persistence
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

        public DbSet<Sale> Sales { get; set; } = null!;
    }
}
