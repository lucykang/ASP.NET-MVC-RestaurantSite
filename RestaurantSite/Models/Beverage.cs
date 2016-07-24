using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class Beverage
    {
        public Beverage() { }
        public Beverage(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return this.Name;
        }
        public virtual int BeverageID { get; set; }
        [Display(Name = "Category")]
        public virtual string Name { get; set; }
        public virtual List<BevItem> BevItems { get; set; }
    }
}