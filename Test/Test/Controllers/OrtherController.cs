using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
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
        public IActionResult ViewOrther(int id)
        {
            ViewBag.customerId = id;
            ViewBag.orthers = db.Customer.Find(id).Orther.ToList();
            return View("ViewOrther");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            int cusId = db.Orther.Find(id).CustomerId;
            db.Orther.Remove(db.Orther.Find(id));
            db.SaveChanges();
            return RedirectToAction("ViewOrther", new { id = cusId });
        }
    }
}