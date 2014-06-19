using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{ 
    //Start with re-explaining the model and how Class represent objects
    //Cover and let the students determine what attributes product should have
    //will need to have price, name, quantity
    //Need Constructor to take the three major variables
    //Add 4 Products to ProductController - will need to add using statement to Models. Cover how namespaces work
    //Explain how Viewbag items are dynamic
    // do a foreach and modify the variables before passing to view
    //Finally, wire Product fields to layout template
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