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
            var username = "Lord User";
            ViewBag.UserName = username;

            Decimal[] prices = new Decimal[] { 5.00m, 3.00m, 2.00m, 70.99m };
            ViewBag.Prices = prices;
            return View();
        }
	}
}