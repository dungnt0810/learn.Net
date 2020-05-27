using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private QuanLyHoaDonContext db;

        public HomeController(QuanLyHoaDonContext _db)
        {
            db = _db;
        }
        
        [Route("~/")]
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.customers = db.Customer.ToList();
            return View("Index");
        }
    }
}