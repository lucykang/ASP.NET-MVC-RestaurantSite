using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantSite.Models;

namespace RestaurantSite.Controllers
{
    public class MenuController : Controller
    {
        LeComptoirContext menuDB = new LeComptoirContext();
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FoodCategory()
        {
            List<Food> food = menuDB.Foods.ToList();
            return View(food);
        }
        public ActionResult BevCategory()
        {
            List<Beverage> bev = menuDB.Beverages.ToList();
            return View(bev);
        }

        //
        //GET: /Menu/Browse?menu=Entree
        public ActionResult BrowseFood(int id = 1)
        {
            var foodModel = menuDB.Foods.Include("FoodItems").Single(f => f.FoodID == id);
            
            return View(foodModel);
        }
        public ActionResult BrowseBeverage(int id = 1)
        {
            var bevModel = menuDB.Beverages.Include("BevItems").Single(f => f.BeverageID == id);
            return View(bevModel);
        }
        //
        //GET: /Menu/Details
        public ActionResult FoodDetails(int id = 1)
        {
            var foodItem = menuDB.FoodItems.Find(id);
            return View(foodItem);
        }
        public ActionResult BevDetails(int id = 1)
        {
            var bevItem = menuDB.BevItems.Find(id);
            return View(bevItem);
        }
    }
}