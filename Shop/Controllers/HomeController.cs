using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Shop.Controllers
{
    public class HomeController: Controller
    {
        private readonly IAllLaptops lapRep;

        public HomeController(IAllLaptops lapRep)
        {
            this.lapRep = lapRep;
        }

        public ViewResult Index()
        {
            var homeLaptops = new HomeViewModel { FavLaptops = lapRep.GetFavLaptops };
            return View(homeLaptops);
        }
    }
}
