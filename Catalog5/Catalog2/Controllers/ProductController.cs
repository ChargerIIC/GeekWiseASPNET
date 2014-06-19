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
        //Dictionary<Product, int> shoppingCartContents = new Dictionary<Product, int>();

        //Dictionary<string, Product> model = new Dictionary<string, Product>()
        //{
        //    {"Widget", new Product("Widget", 10, 2.50m)},
        //    {"SuperWidget", new Product("SuperWidget", 20, 12.99m)},
        //    {"MegaWidget", new Product("MegaWidget", 25, 79.99m)},
        //    {"iWidget", new Product("iWidget", 18, 101.99m)},
        //    {"WidgetKitten", new Product("WidgetKitten", 4, 10.98m)},
        //};

        //
        // GET: /Product/
        public ActionResult Index()
        {
            var username = "Lord User";
            ViewBag.UserName = username;

            foreach(Product product in FakeModel.Instance.Model.Values)
            {
                product.Price -= Decimal.Round(product.Price * 0.15m, 2);
            }
            ViewBag.Products = FakeModel.Instance.Model;

            return View();
        }

        public ActionResult Detail(string id)
        {
            ViewBag.Product = FakeModel.Instance.Model[id];
            return View();
        }

        //Create the empty shoppingcart view
        //create the route and the two optional parameters
        //create FakeModel.cs, demonstrate singletons and add quantity adjustment code
        //Navigate to ShoppingCart and then to 
        public ActionResult ShoppingCart(string id, int amount)
        {
            var product = FakeModel.Instance.Model[id];
            product.Quantity -= amount;

            if (FakeModel.Instance.ShoppingCartContents.ContainsKey(product))
            {
                FakeModel.Instance.ShoppingCartContents[product] += amount;
            }
            else
            {
                FakeModel.Instance.ShoppingCartContents.Add(product, amount);
            }

            ViewBag.Cart = FakeModel.Instance.ShoppingCartContents;

            return View();
        }
	}
}