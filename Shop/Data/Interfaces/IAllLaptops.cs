using System;
using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAllLaptops
    {
        IEnumerable<Laptop> Laptops { get; }

        IEnumerable<Laptop> GetFavLaptops { get; }

        Laptop GetObjectLaptop(int lapId);
    }
}
