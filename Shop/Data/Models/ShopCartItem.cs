using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int ID { get; set; }
        public Laptop Laptop { get; set; }
        public decimal Price { get; set; }
        public string ShopCartID { get; set; }
    }
}
