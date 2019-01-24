using CoffeeShop.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Web.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var test = db.Company.ToList();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
