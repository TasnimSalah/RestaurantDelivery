using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Menu> Menus  { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderMeals> OrderMeals { get; set; }
        public DbSet<CustomerOrders> CustomerOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Menu>().HasKey(a => new { a.RestaurantId , a.MealId });
            builder.Entity<OrderMeals>().HasKey(a => new { a.OrderId , a.MealId });
            builder.Entity<CustomerOrders>().HasKey(a => new { a.OrderId , a.CustomerId });

            builder.Entity<Menu>()
               .HasOne(bc => bc.Restaurant)
               .WithMany(b => b.Menus)
               .HasForeignKey(bc => bc.RestaurantId);
            builder.Entity<Menu>()
                .HasOne(bc => bc.Meal)
                .WithMany(c => c.Menus)
                .HasForeignKey(bc => bc.MealId);
            builder.Entity<OrderMeals>()
               .HasOne(bc => bc.Order)
               .WithMany(b => b.OrderMeals)
               .HasForeignKey(bc => bc.OrderId);
            builder.Entity<OrderMeals>()
                .HasOne(bc => bc.Meal)
                .WithMany(c => c.OrderMeals)
                .HasForeignKey(bc => bc.MealId);
            builder.Entity<CustomerOrders>()
               .HasOne(bc => bc.Order)
               .WithMany(b => b.CustomerOrders)
               .HasForeignKey(bc => bc.OrderId);
            builder.Entity<CustomerOrders>()
                .HasOne(bc => bc.Customer)
                .WithMany(c => c.CustomerOrders)
                .HasForeignKey(bc => bc.CustomerId);


        }


    }
}
