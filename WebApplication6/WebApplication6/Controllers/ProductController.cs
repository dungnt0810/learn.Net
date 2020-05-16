using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }

        [Route("searchwithkeyword")]
        [HttpPost]
        public IActionResult SeachWithKeyword(string keyword)
        {
            
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.Search(keyword);
            ViewBag.keyword = keyword;
            return View("Index");
        }

        [Route("searchwithprice")]
        [HttpPost]
        public IActionResult SeachWithPrice(double min, double max)
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.Search(min, max);
            ViewBag.min = min;
            ViewBag.max = max;
            return View("Index");
        }
    }
}