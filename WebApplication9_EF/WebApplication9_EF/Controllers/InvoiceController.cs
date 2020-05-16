using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication9_EF.Models;

namespace WebApplication9_EF.Controllers
{
    [Route("invoice")]
    public class InvoiceController : Controller
    {
        private Session9DBContext db; 

        public InvoiceController (Session9DBContext _db)
        {
            db = _db;
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var invoice = new Invoice();
            ViewBag.accounts = db.Account.ToList();
            return View("Add", invoice);
        }
    }
}