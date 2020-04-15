using Microsoft.EntityFrameworkCore;

namespace resturantAPI.Models{
    public class DishesContext : DbContext{
        public DishesContext(DbContextOptions<DishesContext> options) : base(options){}
        public DbSet<Dishes> Dishes{ get; set; }
        public DbSet<Appertizer> Appertizer{get; set;}
        public DbSet<Drinks> Drinks{get; set;}
    }
}