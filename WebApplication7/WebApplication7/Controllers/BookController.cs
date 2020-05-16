using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var book = new Book();
            return View("Index", book);
        }

        [Route("save")]
        public IActionResult Save(Book book)
        {
            if (book.Price < 1)
            {
                ModelState.AddModelError("Price", "Price cannot < 1");
            }

            if (ModelState.IsValid)
            {
                Debug.WriteLine("Book " + book.Id);
                return View("Success", book);
            }
            else
            {
                return View("Index", book);
            }
            
        }
    }
}