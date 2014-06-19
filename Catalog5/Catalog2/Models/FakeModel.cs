using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{
    public class FakeModel
    {
        Dictionary<Product, int> shoppingCartContents;
        Dictionary<string, Product> model;

        FakeModel()
        {
            shoppingCartContents = new Dictionary<Product, int>();

            model = new Dictionary<string, Product>()
            {
                {"Widget", new Product("Widget", 10, 2.50m)},
                {"SuperWidget", new Product("SuperWidget", 20, 12.99m)},
                {"MegaWidget", new Product("MegaWidget", 25, 79.99m)},
                {"iWidget", new Product("iWidget", 18, 101.99m)},
                {"WidgetKitten", new Product("WidgetKitten", 4, 10.98m)},
            };
        }

        public Dictionary<Product, int> ShoppingCartContents
        {
            get { return shoppingCartContents; }
        }

        public Dictionary<string, Product> Model
        {
            get { return model; }
        }

        static readonly FakeModel _instance = new FakeModel();
        public static FakeModel Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}