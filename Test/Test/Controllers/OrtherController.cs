using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    
    [Route("orther")]
    public class OrtherController : Controller
    {
        private QuanLyHoaDonContext db;

        public OrtherController(QuanLyHoaDonContext _db)
        {
            db = _db;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.customers = db.Customer.ToList();
            return View("Index");
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var orther = new Orther();
            return View("Index");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Orther orther)
        {
            
            db.Orther.Add(orther);
            db.SaveChanges();
            return RedirectToAction("Index", "Orther");
        }

        [Route("vieworther")]
        public IActionResult ViewOrther(int customerId)
        {
            ViewBag.customerId = customerId;
            ViewBag.orthers = db.Customer.Find(customerId).Orther.ToList();
            return View("ViewOrther");
        }
    }
}