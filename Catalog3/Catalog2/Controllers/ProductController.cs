using Catalog2.Models;
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

            ViewBag.Products = new Dictionary<string, Product>()
            {
                {"Widget", new Product("Widget", 10, 2.50m)},
                {"SuperWidget", new Product("SuperWidget", 20, 12.99m)},
                {"MegaWidget", new Product("MegaWidget", 25, 79.99m)},
                {"iWidget", new Product("iWidget", 18, 101.99m)},
                {"WidgetKitten", new Product("WidgetKitten", 4, 10.98m)},
            };

            foreach(Product product in ViewBag.Products.Values)
            {
                product.Price -= Decimal.Round(product.Price * 0.15m, 2);
            }

            return View();
        }
	}
}