using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag tạo biến cho page
            ViewBag.age = 20;
            ViewBag.username = "avd";
            ViewBag.date = DateTime.Now;
            ViewBag.status = true;
            ViewBag.product = new Product { 
                id = "pd01",
                name = "adas",
                photo = "123.jpg",
                created = DateTime.Now,
                quantity = 11,
                price = 231,
            };
            List<Product> products = new List<Product> {
                new Product {
                id = "pd01",
                name = "adas",
                photo = "123.jpg",
                created = DateTime.Now,
                quantity = 11,
                price = 231,
            },
                new Product {
                id = "pd02",
                name = "adas",
                photo = "2.jpg",
                created = DateTime.Now,
                quantity = 11,
                price = 231,
            },
                new Product {
                id = "pd03",
                name = "adas",
                photo = "654.jpg",
                created = DateTime.Now,
                quantity = 11,
                price = 231,
            },
        };
            ViewBag.products = products;
            ViewBag.total = products.Sum(p => p.quantity * p.price);

            return View();
        }
    }
}