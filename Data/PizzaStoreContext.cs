using BlazingPizza.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data
{
    public class PizzaStoreContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<PizzaSpecial> Specials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PizzaTopping> PizzaToppings { get; set; }
        public DbSet<UserInfo> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Junction table için composite key
            modelBuilder.Entity<PizzaTopping>()
                .HasKey(pt => new { pt.PizzaId, pt.ToppingId });
        }
    }
}
