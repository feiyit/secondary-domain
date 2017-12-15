using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomainTs.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            var cityName = RouteData.Values["CityNameUrl"];
            ViewBag.CityName = cityName;
            return View();
        }
    }
}