using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Menu/
        public ActionResult Menu()
        {
            ViewBag.Message = "Your application description page.";

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