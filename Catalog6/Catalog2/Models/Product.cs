using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{ 
    //Explain Entity Framework and that we'll be doing this code-first
    //Explain difference between code first and database first
    //Rename FakeModel to ShoppingCart.cs and remove singleton attributes
    //Add CartId
    //Install Entity Framework via nuget
    //Create ProductContext
    //Create DbSets for Product/ShoppingCart
    //Modify Product Controller to use Model
    //Take a break
    //Modify Index view to use model - use foreach
    public class Product
    {
        public Product(int id,string name, int quanity, Decimal price)
        {
            Id = id;
            Name = name;
            Quantity = quanity;
            Price = price;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public Decimal Price { get; set; }
    }
}