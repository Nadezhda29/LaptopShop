using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Laptop> FavLaptops { get; set; }
    }
}
