using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantSite.Models
{
    public class MenuData : DropCreateDatabaseIfModelChanges<LeComptoirContext>
    {
        protected override void Seed(LeComptoirContext context)
        {
            var foods = new List<Food>
           {
               new Food { Name = "Entree" },
               new Food { Name = "Main" },
               new Food { Name = "Dessert" }
           };

            var bevs = new List<Beverage>
            {
                new Beverage { Name = "Beer" },
                new Beverage { Name = "Wine" },
                new Beverage { Name = "Soft Drink" },
                new Beverage { Name = "Champagne" }
            };

            new List<FoodItem>
            {
                new FoodItem { Name = "Pan-fried Mushrooms", Price = 20.00, ShortDescription = "Mixed pan-fried Mushroom with poached egg and ham", LongDescription="Mixed pan-fried garlicky mushrooms in demi-glace with a poached egg and ham.", Food = foods.Single(f => f.Name == "Entree"), Image="/Assets/"},
                new FoodItem { Name = "Squid's Ink Risotto", Price = 23.00, ShortDescription = "Squid's ink risotto and roasted Norway lobster", LongDescription="Squid's ink risotto, roasted Norway lobster in clam juice foam", Food = foods.Single(f => f.Name == "Entree"), Image="/Assets/"},
                new FoodItem { Name = "Le Comptoir Foie Gras", Price = 25.00, ShortDescription = "Le Comptoir special menu", LongDescription="Le Comptoir chef style's terrine foie gras.", Food = foods.Single(f => f.Name == "Entree"), Image="/Assets/"},
                new FoodItem { Name = "Roasted Quail", Price = 49.00, ShortDescription = "Stuffed roasted quail", LongDescription="Roasted quail, foie-gras and truffles with coated honey and spices.", Food = foods.Single(f => f.Name == "Main"), Image="/Assets/"},
                new FoodItem { Name = "Fish of The Day", Price = 40.00, ShortDescription = "Chef's seasonal fish", LongDescription="Seasonal Fish. Please ask server for more detail.", Food = foods.Single(f => f.Name == "Main"), Image="/Assets/"},
                new FoodItem { Name = "French Veal Pie", Price = 50.00, ShortDescription = "Traditional French style veal pie", LongDescription="Traditional French veal pie with foie gras and boletus, black truffle sauce.", Food = foods.Single(f => f.Name == "Main"), Image="/Assets/"},
                new FoodItem { Name = "Le Comptoir Special Profiteroles", Price = 16.00, ShortDescription = "Le Comptoir special dessert", LongDescription="Choux with ice cream and patissier cream with its chocolate sauce.", Food = foods.Single(f => f.Name == "Dessert"), Image="/Assets/"},
                new FoodItem { Name = "Millefeuille", Price = 16.50, ShortDescription = "Millefeuille with seasonal fruits", LongDescription="Millefeuille with seasonal fruits, with chocolate and wild berry coulis.", Food = foods.Single(f => f.Name == "Dessert"), Image="/Assets/"},
                new FoodItem { Name = "Cottage Cheese", Price = 15.00, ShortDescription = "Cottage cheese with seasonal fruits", LongDescription="Cottage cheese with seasonal fruits.", Food = foods.Single(f => f.Name == "Dessert"), Image="/Assets/"},
            }.ForEach(f => context.FoodItems.Add(f));

            new List<BevItem>
            {
                new BevItem { Name = "Moet & Chandon Brut Imperial", Price = 70.00, ShortDescription = "Champagne, France", LongDescription="Pale straw in colour with a fine mousse; defined aromas of apple, pear, citrus and fresh baked bread; the palate is extra-dry and medium body with lovely replay of flavours from the nose with a mineral note on a clean finish.", Beverage = bevs.Single(f => f.Name == "Champagne"), Image="/Assets/"},
                new BevItem { Name = "Famille Perrin Les Christins Vacqueyras 2012", Price = 30.00, ShortDescription = "Rhône, France", LongDescription="The beautiful 2012 Vacqueyras (75% Grenache and 25% Syrah), which comes from 16 hectares located on a plateau behind the village, is a rounded, sexy effort that has beautiful bouquet garni, pepper, licorice and dried-soil aromas to go with ample sweet black raspberry fruit. Forward, full-bodied, and textured, it's a pleasure-bent effort to drink over the coming 5-8 years. Score - 91. (Jeb Dunnuck, robertparker.com, Oct. 2014)", Beverage = bevs.Single(f => f.Name == "Wine"), Image="/Assets/"},
                new BevItem { Name = "Leffe Blonde", Price = 20.00, ShortDescription = "Belgium", LongDescription="Golden colour; spicy aroma with delicate malt sweetness; a traditional, full-bodied and well-balanced abbey beer.", Beverage = bevs.Single(f => f.Name == "Beer"), Image="/Assets/"},
                new BevItem { Name = "Lemon Lime Bitters", Price = 8.00, ShortDescription = "Australia", LongDescription="Sweet and sour fizzy drink.", Beverage = bevs.Single(f => f.Name == "Soft Drink"), Image="/Assets/"},
                new BevItem { Name = "Coka Cola", Price = 5.00, ShortDescription = "Coke, Coke Zero, Diet Coke", LongDescription="Coke from Coka Cola.", Beverage = bevs.Single(f => f.Name == "Soft Drink"), Image="/Assets/"},
            }.ForEach(f => context.BevItems.Add(f));
        }
    }
}