using Microsoft.EntityFrameworkCore;
using PizzaRendelesiAPI.Entities;

namespace PizzaRendelesiAPI.Context
{
    public class PizzaOrderContext : DbContext
    {
        public PizzaOrderContext(DbContextOptions<PizzaOrderContext> options) :base (options) { }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
