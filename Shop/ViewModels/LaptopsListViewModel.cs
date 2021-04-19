using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class LaptopsListViewModel
    {
        public IEnumerable<Laptop> AllLaptops { get; set; }

        public string CurrCategory { get; set; }
    }
}
