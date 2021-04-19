using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class LaptopsController: Controller
    {
        private readonly IAllLaptops allLaptops;
        private readonly ILaptopsCategory allCategories;

        public LaptopsController(IAllLaptops iAllLaptops, ILaptopsCategory iLaptopsCat)
        {
            allLaptops = iAllLaptops;
            allCategories = iLaptopsCat;
        }

        [Route("Laptops/List")]
        [Route("Laptops/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Laptop> laptops = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                laptops = allLaptops.Laptops.OrderBy(i => i.ID);
            }
            else
            {
                if (string.Equals("gaming", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Игровые ноутбуки")).OrderBy(i => i.ID);
                    currCategory = "Игровые ноутбуки";
                }
                else if (string.Equals("ordinary", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Обычные ноутбуки")).OrderBy(i => i.ID);
                    currCategory = "Обычные ноутбуки";
                }
            }

            var lapObj = new LaptopsListViewModel { AllLaptops = laptops, CurrCategory = currCategory };
            ViewBag.Title = "Страница с ноутбуками";

            return View(lapObj);
        }
    }
}
