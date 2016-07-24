using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class Menu
    {
        /// <summary>
        /// Empty Contructor
        /// </summary>
        public Menu()
        {

        }
        /// <summary>
        /// Overloaded Contructor
        /// </summary>
        /// <param name="menu"></param>
        public Menu(Food menu)
        {
            //this.Food = menu;
        }
        public Menu(Beverage menu)
        {
            //this.Beverage = menu;
        }
        public Menu(string menu)
        {
            this.Name = menu;
        }
        public virtual int MenuID { get; set; }
        public virtual string Name { get; set; }
        public virtual string MenuImage { get; set; }
        //public virtual Food Food { get; set; }
        //public virtual Beverage Beverage { get; set; }
    }
}