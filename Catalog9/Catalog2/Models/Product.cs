using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{ 

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