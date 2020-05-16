using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class CartController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View("Index");
        }


        [Route("buy/{id}")]
        public IActionResult Buy(string id)
        {
            ProductModel productModel = new ProductModel();
            Product product = productModel.find(id);
            if (HttpContext.Session.GetString("cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { product = product, Quantity = 1 });
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            }
            else
            {

            }
            return RedirectToAction("Index","cart");
        }
    }
}