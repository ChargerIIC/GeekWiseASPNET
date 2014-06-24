using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{ 
    
    public class Product
    {
        public Product(string name, int quanity, Decimal price)
        {
            Name = name;
            Quantity = quanity;
            Price = price;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public Decimal Price { get; set; }
    }
}