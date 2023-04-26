using Microsoft.EntityFrameworkCore;
using StatePatternEFCore.Domains.Order;
using StatePatternEFCore.Helpers;

namespace StatePatternEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .Property(x => x.OrderState)
                .HasConversion(new StateConverter(ReflectionHelper.FindOrderStateSubclasses()));
        }
    }
}
