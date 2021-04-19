﻿using System;
using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }
        public List<Laptop> Laptops { get; set; }
    }
}
