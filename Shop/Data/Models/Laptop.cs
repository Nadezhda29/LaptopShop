using System;

namespace Shop.Data.Models
{
    public class Laptop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        public bool IsFavourite { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
