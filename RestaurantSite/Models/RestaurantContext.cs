using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class RestaurantContext : DbContext
    {
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Beverage> Beverages { get; set; }
        public virtual DbSet<FoodItem> FoodItems { get; set; }
        public virtual DbSet<BevItem> BevItems { get; set; }
    }
}