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
        //RestaurantContext restaurantDB = new RestaurantContext();
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            //display 'food' & 'beverage' categories
            //List<Food> foodMenu = restaurantDB.FoodMenu.ToList();
            //List<Beverage> bevMenu = restaurantDB.BevMenu.ToList();
            /*
            List<Food> foodMenu = new List<Food>
            {
                new Food("Entree"),
                new Food("Main"),
                new Food("Dessert")
            };
            List<Beverage> bevMenu = new List<Beverage>
            {
                new Beverage("Beer"),
                new Beverage("Wine"),
                new Beverage("Soft Drink")
            };
            */
            /*
            List<Menu> menu = new List<Menu>
            {
                new Menu(new Food("Entree")),
                new Menu(new Food("Main")),
                new Menu(new Food("Dessert")),
                new Menu(new Beverage("Beer")),
                new Menu(new Beverage("Wine")),
                new Menu(new Beverage("Soft Drink"))
            };
            
            List<Menu> menu = new List<Menu>
            {
                new Menu("Beverage"),
                new Menu("Food")
            };
            */
            return View();
        }
        public ActionResult FoodCategory(string category)
        {
            List<Food> food = new List<Food>
            {
                new Food("Entree"),
                new Food("Main"),
                new Food("Dessert")
            };
            return View(food);
        }
        public ActionResult BevCategory(string category)
        {
            List<Beverage> bev = new List<Beverage>
            {
                new Beverage("Champagne"),
                new Beverage("Beer"),
                new Beverage("Wine"),
                new Beverage("Soft Drink")
            };
            return View(bev);
        }

        //
        //GET: /Menu/Browse?menu=Entree
        public ActionResult BrowseFood(string menu = "Entree")
        {
            //var foodModel = restaurantDB.FoodMenu.Include("Items").Single(f => f.Name = menu);
            Food foodModel = new Food(menu);
            return View(foodModel);
        }
        public ActionResult BrowseBeverage(string menu = "Wine")
        {
            //var bevModel = restuarantDB.BevMenu.Include("Items").Single(b => b.Name = menu);
            Beverage bevModel = new Beverage(menu);
            return View(bevModel);
        }
        //
        //GET: /Menu/Details
        public ActionResult FoodDetails(int id = 1)
        {
            //var item = restaurantDB.Items.Find(id);
            var foodItem = new FoodItem("Item ID #" + id);
            return View(foodItem);
        }
        public ActionResult BevDetails(int id = 1)
        {
            //var item = restaurantDB.Items.Find(id);
            var bevItem = new BevItem("Item ID #" + id);
            return View(bevItem);
        }
    }
}