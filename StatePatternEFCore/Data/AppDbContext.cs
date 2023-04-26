using Microsoft.EntityFrameworkCore;
using StatePatternEFCore.Domains.Order;

namespace StatePatternEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<Order> Order { get; set; }
    }
}
