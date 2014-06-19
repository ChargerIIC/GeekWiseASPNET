using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog2.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            //Introduce var and explain strong typing
            var username = "Lord User";
            ViewBag.UserName = username;

            //Explain difference between Decimal and Double
            //Decimal for money - double for everything else
            //Introduce array intialization
            //Start with Decimal[] prices = new Decimal[];
            //prices.Add(5.00m);
            Decimal[] prices = new Decimal[] { 5.00m, 3.00m, 2.00m, 70.99m };
            ViewBag.Prices = prices;
            return View();

            //Add Route to RouteConfig
            //Get bootstrap template
            //explain StartBootstrap.com
            //http://startbootstrap.com/shop-homepage
            //Add Username through @Viewbag.UserName
            //Add Prices via ViewBag.Prices[x]

            //Take a breather and go over debugging
            //Make a mistake (Prices[4]) and go over how to use intellisense and immediate window
        }
	}
}