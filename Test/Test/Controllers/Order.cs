using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Test.Models;

namespace Test.Controllers
{

    [Route("order")]
    public class orderController : Controller
    {
        private QuanLyHoaDonContext db;

        public orderController(QuanLyHoaDonContext _db)
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
            var order = new Order();
            return View("Index");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Order order)
        {

            db.Order.Add(order);
            db.SaveChanges();
            return RedirectToAction("Index", "order");
        }

        [Route("vieworder")]
        public IActionResult Vieworder(int id)
        {
            ViewBag.customerId = id;
            ViewBag.orders = db.Customer.Find(id).Order.ToList();
            return View("Vieworder");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            int cusId = db.Order.Find(id).CustomerId;
            db.Order.Remove(db.Order.Find(id));
            db.SaveChanges();
            return RedirectToAction("Vieworder", new { id = cusId });
        }
    }
}