using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class FoodItem
    {
        /// <summary>
        /// Empty Contructor
        /// </summary>
        public FoodItem()
        {

        }
        /// <summary>
        /// Overloaded Contructor
        /// </summary>
        /// <param name="Name"></param>
        public FoodItem(string Name)
        {
            this.Name = Name;
        }
        public virtual int ItemID { get; set; }
        public virtual int FoodID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string LongDescription { get; set; }
        public virtual double Price { get; set; }
        public virtual string Image { get; set; }
        public virtual Food Food { get; set; }
    }
}