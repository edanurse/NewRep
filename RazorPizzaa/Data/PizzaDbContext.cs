using Microsoft.EntityFrameworkCore;
using RazorPizzaa.Model;

namespace RazorPizzaa.Data
{
    public class PizzaDbContext :DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> option) : base(option)
        {
            
        }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
    }
}
