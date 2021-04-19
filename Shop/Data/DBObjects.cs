using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Laptop.Any())
            {
                content.Laptop.AddRange(
                    new Laptop
                    {
                        Name = "HP Pavilion Gaming",
                        ShortDesc = "Тонкий и мощный игровой ноутбук",
                        Img = "https://3.downloader.disk.yandex.ru/preview/dfeae25badde151d688100dbe543c70145158770bbbf42a1b7e5f6c26bb03156/inf/scikhd6bb_CoyrIIf7hZ9BSJhvmRGGKQ_oUa-GAKYXyjC-Vzui6IIw0rxmyQdb71qCMgoLfLFmfotRentcc-4w%3D%3D?uid=221384652&filename=hp.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                        Price = 81690,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Игровые ноутбуки"]
                    },
                    new Laptop
                    {
                        Name = "Honor MagicBook 14",
                        ShortDesc = "Ультратонкий 14-дюймовый ноутбук",
                        Img = "https://4.downloader.disk.yandex.ru/preview/c9349bf1cb81fe298c45707cba693ae967b03dd392560194df56ce6fd47297ef/inf/y_1C9eLPIwmuvL1qr2XrfRSJhvmRGGKQ_oUa-GAKYXwSCZU0IdQX2VAalIRd2SbXWovRlrlL_fXlgEzXdTzrLQ%3D%3D?uid=221384652&filename=magicBook.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                        Price = 45809,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Обычные ноутбуки"]
                    },
                    new Laptop
                    {
                        Name = "Acer Aspire 5",
                        ShortDesc = "Стильный дизайн, высокая производительность",
                        Img = "https://4.downloader.disk.yandex.ru/preview/bb8a518fa309bf4b3e22742ef1bc40567bfb905a7260adad39ac37bdd69d7749/inf/Cxby-zrPbj4Q0apuaB79mRSJhvmRGGKQ_oUa-GAKYXzx8h-Ie-7F-KCBnbHXrXvXdsb0fkNsImBu3Wbu6Kjc7A%3D%3D?uid=221384652&filename=acer.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                        Price = 55634,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Обычные ноутбуки"]
                    },
                    new Laptop
                    {
                        Name = "Lenovo IdeaPad 5",
                        ShortDesc = "Оснащен всем необходимым для работы",
                        Img = "https://4.downloader.disk.yandex.ru/preview/3a6585e57184e713cae6b5757ea0127e5daf0045122cebe264c2dcfcd19989e8/inf/aPNah4o1nvqc9JKnKgIk7RSJhvmRGGKQ_oUa-GAKYXz9azxKJt1eL2zCQmkpvj1Uq8ZIl9Nmm8yJS9uNkKDpvA%3D%3D?uid=221384652&filename=lenovo.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                        Price = 46905,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Обычные ноутбуки"]
                    },
                    new Laptop
                    {
                        Name = "Asus Expertbook",
                        ShortDesc = "Ноутбук для корпоративных пользователей",
                        Img = "https://2.downloader.disk.yandex.ru/preview/24898c3fc63d87de223883518fd172605ef3aa204921fcbaa516e8722897099c/inf/uuiTFiQ5Uz9m6o3EAoJJGhSJhvmRGGKQ_oUa-GAKYXzjUbS_RBZcRxrGAW8NzM2HU9a2m7LZWsD4rT8C004ldg%3D%3D?uid=221384652&filename=ASUS.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                        Price = 67342,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Обычные ноутбуки"]
                    },
                    new Laptop
                    {
                        Name = "Apple MacBook Air 13",
                        ShortDesc = "Ноутбук с процессором Intel Core 5-го поколения",
                        Img = "https://4.downloader.disk.yandex.ru/preview/14d00c9a417cad0a4849e070015b81c1ca8deee32cdee0fde43a738e22e3cf6e/inf/drPSawev0nirkEEIu-lPOxSJhvmRGGKQ_oUa-GAKYXygHtl-YZrR-xiBRdVCFbPzuFnd8gAd8FrtD3QOklqA1g%3D%3D?uid=221384652&filename=macBook.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                        Price = 78295,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Обычные ноутбуки"]
                    },
                     new Laptop
                     {
                         Name = "MSI GL65",
                         ShortDesc = "Оснащен мощным процессором",
                         Img = "https://1.downloader.disk.yandex.ru/preview/fc926934a0acfa70ede3128478a2367f68247f7620dfdf2ba02d77f15d456eec/inf/DYyPqtX41cfQgvC_jsvXVRSJhvmRGGKQ_oUa-GAKYXxN7QaK1xRwBM0c3_7hzkIESQMeze-JzTLoC1gol5FxOw%3D%3D?uid=221384652&filename=msi.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                         Price = 76308,
                         IsFavourite = true,
                         Available = true,
                         Category = Categories["Игровые ноутбуки"]
                     },
                      new Laptop
                      {
                          Name = "Dell G3",
                          ShortDesc = "Надежный и производительный ноутбук",
                          Img = "https://4.downloader.disk.yandex.ru/preview/3b140518285bc6c1f196d5a2d6265b2b952ff109132345e10d0c0cd80df4f833/inf/zpFgDHQmZJo9dZ0PfKeGZBSJhvmRGGKQ_oUa-GAKYXx8ndJFBXcLX25WUu8v_4M_D3olQBF--NSqPEkcLZjoJw%3D%3D?uid=221384652&filename=dell.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=221384652&tknv=v2&size=1349x652",
                          Price = 81479,
                          IsFavourite = false,
                          Available = true,
                          Category = Categories["Игровые ноутбуки"]
                      }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories {
            get {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Игровые ноутбуки", Desc = "Ноутбуки для игр" },
                        new Category { CategoryName = "Обычные ноутбуки", Desc = "Ноутбуки для офиса и учебы" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }

                return category;
            } 
        }
    }
}
