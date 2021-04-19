using System;
using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface ILaptopsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
