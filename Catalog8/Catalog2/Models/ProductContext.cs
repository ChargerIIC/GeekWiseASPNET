using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Catalog2.Models
{
    public class ProductContext : DbContext 
    {
        public ProductContext()
            : base(@"Server=(local)\SQLEXPRESS;Database=LocalDb;Integrated Security=true;")
        {
            if (Products.Count() == 0)
            {
                this.Products.AddRange(new List<Product>(){new Product(1,"Widget", 10, 2.50m), new Product(2,"SuperWidget", 20, 12.99m)
                ,new Product(3,"MegaWidget", 25, 79.99m), new Product(4,"iWidget", 18, 101.99m),new Product(5,"WidgetKitten", 4, 10.98m)});
                this.SaveChanges();
            }

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}