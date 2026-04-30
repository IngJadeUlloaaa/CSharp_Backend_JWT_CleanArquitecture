using Microsoft.EntityFrameworkCore;
using Products_CleanArquitecture.Domain.Entities;


namespace Products_CleanArquitecture.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customers> Customers { get; set; }
    }
}