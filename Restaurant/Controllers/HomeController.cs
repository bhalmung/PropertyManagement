using DomainLogic.Serivce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModels;
namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        IRestaurentService _RestaurentService;
        public HomeController(IRestaurentService s)
        {
            _RestaurentService = s;
        }
        public ActionResult Index()
        {
           
           
            return View( );
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