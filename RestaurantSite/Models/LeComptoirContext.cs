namespace RestaurantSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LeComptoirContext : DbContext
    {
        public LeComptoirContext()
            : base("name=LeComptoirConnection")
        {
        }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Beverage> Beverages { get; set; }
        public virtual DbSet<FoodItem> FoodItems { get; set; }
        public virtual DbSet<BevItem> BevItems { get; set; }
    }
}
