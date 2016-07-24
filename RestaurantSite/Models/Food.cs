using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class Food
    {
        public Food() { }
        public Food(string name)
        {
            this.Name = name;
        }
        
        public virtual int FoodID { get; set; }
        [Display(Name="Category")]
        public virtual string Name { get; set; }
        public virtual List<FoodItem> FoodItems { get; set; }
    }
}