using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ShopCartController: Controller
    {
        private readonly IAllLaptops lapRep;
        private readonly ShopCart shopCart;

        public ShopCartController(IAllLaptops lapRep, ShopCart shopCart)
        {
            this.lapRep = lapRep;
            this.shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = shopCart.GetShopItems();
            shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel { ShopCart = shopCart };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = lapRep.Laptops.FirstOrDefault(i => i.ID == id);
            if (item != null)
            {
                shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
