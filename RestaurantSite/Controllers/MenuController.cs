using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantSite.Models;

namespace RestaurantSite.Controllers
{
    /*
        File: MenuController.cs
        Author: Lucy Kang
        Website: Le Comptoir Restaurant & Bar
        Description: This controller routes index, food/BevCategory, BrowseFood/Beverage and Food/BevDetails page.
    */
    public class MenuController : Controller
    {
        LeComptoirContext menuDB = new LeComptoirContext();
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Menu/FoodCategory/
        public ActionResult FoodCategory()
        {
            List<Food> food = menuDB.Foods.ToList();
            return View(food);
        }
        //
        // GET: /Menu/BevCategory/
        public ActionResult BevCategory()
        {
            List<Beverage> bev = menuDB.Beverages.ToList();
            return View(bev);
        }

        //
        //GET: /Menu/BrowseFood/1
        public ActionResult BrowseFood(int id = 1)
        {
            var foodModel = menuDB.Foods.Include("FoodItems").Single(f => f.FoodID == id);
            
            return View(foodModel);
        }
        //
        //Get: /Menu/BrowseBeverage/1
        public ActionResult BrowseBeverage(int id = 1)
        {
            var bevModel = menuDB.Beverages.Include("BevItems").Single(f => f.BeverageID == id);
            return View(bevModel);
        }
        //
        //GET: /Menu/FoodDetails/1
        public ActionResult FoodDetails(int id = 1)
        {
            var foodItem = menuDB.FoodItems.Find(id);
            return View(foodItem);
        }
        //
        // GET: /Menu/BevDetails/1
        public ActionResult BevDetails(int id = 1)
        {
            var bevItem = menuDB.BevItems.Find(id);
            return View(bevItem);
        }
    }
}