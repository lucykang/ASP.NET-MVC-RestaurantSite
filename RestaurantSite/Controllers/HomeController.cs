using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSite.Controllers
{
    /*
        File: HomeController.cs
        Author: Lucy Kang
        Website: Le Comptoir Restaurant & Bar
        Description: This controller routes Landing and Contact page
    */
    public class HomeController : Controller
    {
        //
        // GET: /
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Visit Us";

            return View();
        }
    }
}