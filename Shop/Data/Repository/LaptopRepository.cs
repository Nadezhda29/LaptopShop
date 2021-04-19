using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repository
{
    public class LaptopRepository : IAllLaptops
    {
        private readonly AppDBContent appDBContent;

        public LaptopRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Laptop> Laptops => appDBContent.Laptop.Include(c => c.Category);

        public IEnumerable<Laptop> GetFavLaptops => appDBContent.Laptop.Where(p => p.IsFavourite).Include(c => c.Category);

        public Laptop GetObjectLaptop(int lapId) => appDBContent.Laptop.FirstOrDefault(p => p.ID == lapId);
    }
}
