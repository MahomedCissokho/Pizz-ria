using Microsoft.EntityFrameworkCore;

namespace Pizz�ria.Models
{
    public class PizzaEhodDB : DbContext
    {
        public PizzaEhodDB(DbContextOptions options) : base(options) { }

        public DbSet<PizzaEhod> Pizzas { get; set; } = null!;
    }
}