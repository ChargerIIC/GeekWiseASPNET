using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog2.Models
{
    public class ShoppingCart
    {

        public ShoppingCart()
        {
            Contents = new Dictionary<Product, int>();
        }

        [Key]
        public string CartID { get; set; }

        public Dictionary<Product, int> Contents { get; set; }

    }
}