using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
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

        [Route("detail/{id}")]
        public IActionResult Detail(string id)
        {
            ProductModel productModel = new ProductModel();
            ViewBag.product = productModel.find(id);
            return View("Detail");
        }
    }
}