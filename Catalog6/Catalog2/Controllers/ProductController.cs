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
        ProductContext productModel;
        ShoppingCart shoppingCart;

        public ProductController()
        {
            productModel = new ProductContext();
            shoppingCart = productModel.ShoppingCarts.Add(new Models.ShoppingCart());
        }

        //
        // GET: /Product/
        public ActionResult Index()
        {
            var username = "Lord User";
            ViewBag.UserName = username;

            foreach (Product product in productModel.Products.Local)
            {
                product.Price -= Decimal.Round(product.Price * 0.15m, 2);
            }
            ViewBag.Products = productModel.Products.Local;

            var prod = productModel.Products.Local.ToList();

            return View();
        }

        public ActionResult Detail(string id)
        {
            ViewBag.Product = productModel.Products.Single(x => x.Name == id);
            return View();
        }

        public ActionResult ShoppingCart(string id, int amount)
        {
            var product = productModel.Products.Single(x => x.Name == id);
            product.Quantity -= amount;

            if (shoppingCart.Contents.ContainsKey(product))
            {
                shoppingCart.Contents[product] += amount;
            }
            else
            {
                shoppingCart.Contents.Add(product, amount);
            }

            ViewBag.Cart = shoppingCart.Contents;

            return View();
        }
	}
}