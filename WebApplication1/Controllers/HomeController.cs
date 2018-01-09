using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace WebApplication1.Controllers
{
    public static class plural
    {
        /// <summary>
        /// Returns the plural form of the specified word.
        /// </summary>
        /// <param name="count">How many of the specified word there are. A count equal to 1 will not pluralize the specified word.</param>
        /// <returns>A string that is the plural form of the input parameter.</returns>
        public static string ToPlural(this string @this, int count = 0)
        {
            return count == 1 ? @this : System.Data.Entity.Design.PluralizationServices.PluralizationService.CreateService(new System.Globalization.CultureInfo("en-US")).Pluralize(@this);
        }

    }

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "The Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Pluralize(string input, FormCollection collection)
        {

            switch (input)
            {
                case "Pluralize":
                    // do some stuff...
                    ViewBag.Title = "Home Page";

                    string plural = Request["txtWord"];


                    var s = plural.ToPlural();
                    ViewBag.Plural = s;
                    break;
                case "Create Account":

                    break;

               default:
                     ViewBag.Title = "Home Page";

                     plural = Request["txtWord"];


                     s = plural.ToPlural();
                    ViewBag.Plural = s;
                    break;
                    // do some other stuff...
                    break;
            }
          
            
            return View("Index");
        }

      
    }
}
