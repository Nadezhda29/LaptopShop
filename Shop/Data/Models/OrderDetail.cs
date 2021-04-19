using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int LaptopID { get; set; }
        public decimal Price { get; set; }
        public virtual Laptop Laptop { get; set; }
        public virtual Order Order { get; set; }

    }
}
