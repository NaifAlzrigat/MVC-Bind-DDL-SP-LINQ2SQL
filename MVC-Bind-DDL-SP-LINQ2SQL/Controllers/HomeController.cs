using MVC_Bind_DDL_SP_LINQ2SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Bind_DDL_SP_LINQ2SQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BikeStoresEntities db = new BikeStoresEntities();
            ViewBag.message = new SelectList(db.Get_Bike_Categories(), "category_name");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}