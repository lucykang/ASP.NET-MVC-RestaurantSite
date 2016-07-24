using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class BevItem
    {
        /// <summary>
        /// Empty Contructor
        /// </summary>
        public BevItem()
        {

        }
        /// <summary>
        /// Overloaded Contructor
        /// </summary>
        /// <param name="Name"></param>
        public BevItem(string Name)
        {
            this.Name = Name;
        }
        public virtual int BevItemID { get; set; }
        public virtual int BeverageID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string LongDescription { get; set; }
        public virtual double Price { get; set; }
        public virtual string Image { get; set; }
        public virtual Beverage Beverage { get; set; }
    }
}