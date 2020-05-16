using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication9_FlowerShop.Models;

namespace WebApplication9_FlowerShop.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        public Session9DBContext db;

        public HomeController(Session9DBContext _db)
        {
            db = _db;
        }

        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.FeaturedProducts = db.Product.Where(p => p.Featured).Take(2).ToList();
            ViewBag.NewProducts = db.Product.OrderByDescending(p => p.Id).Take(3).ToList();
            return View();
        }
    }
}