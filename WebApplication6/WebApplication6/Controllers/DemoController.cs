using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        [Route("search")]
        public IActionResult Search(string keyword)
        {
            Debug.WriteLine("key word: " + keyword);
            return View("Index");
        }

        [HttpPost]
        [Route("search2")]
        public IActionResult Search2(double min, double max)
        {
            Debug.WriteLine("min: " + min);
            Debug.WriteLine("max: " + max);
            return View("Index");
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(int[] quantity)
        {
            foreach (var qty in quantity)
            {
                Debug.WriteLine(qty);
            }
            return View("Index");
        }


    }
}