using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{ 
    //Explain the different Auth Models
    //Explain that we'll be using OWIN and expanding it to store user data in the database
    //Need to cover that many application use a seperate database for authentication
    //View Startup.Auth.cs and explain the OAuth options and how they are better for small applications
    //Add first name and last name properties to Identity Models.cs
    //Add same properties to the AccountViewModel
    //Add fields to Register.cshtml
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