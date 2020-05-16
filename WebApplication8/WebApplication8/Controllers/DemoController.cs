using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    { 
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var product = new Product {
                Id = "p01",
                Name = "name 1",
                Price = 4,
            };

            string strProduct = JsonConvert.SerializeObject(product);
            HttpContext.Session.SetString("product", strProduct);

            List<Product> products = new List<Product>()
            {
                new Product { Id = "p01", Name = "name 1", Price = 4,},
                new Product { Id = "p02", Name = "name 2", Price = 4,},
                new Product { Id = "p03", Name = "name 3", Price = 6,},
            };
            string strProducts = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("products", strProducts);

            return View();
        }

        [Route("display1")]
        public IActionResult Display1()
        {
            string strProduct = HttpContext.Session.GetString("product");
            Product product = JsonConvert.DeserializeObject<Product>(strProduct);
            Debug.WriteLine("id : " + product.Id);
            Debug.WriteLine("name: " + product.Name);

            //huy session
            HttpContext.Session.Remove("product");
            return View("Index");
        }

        [Route("display2")]
        public IActionResult Display2()
        {
            string strProducts = HttpContext.Session.GetString("products");
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(strProducts);
            foreach (var product in products)
            {
                Debug.WriteLine("id : " + product.Id);
                Debug.WriteLine("name: " + product.Name);
            }

            return View("Index");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Account account)
        {
            Account account1 = new Account() { Username = "acc1", Password = "123" };
            if (account1.Password == account.Password && account1.Username == account.Username)
            {
                HttpContext.Session.SetString("username", account.Username);
                Debug.WriteLine(HttpContext.Session.GetString("username"));
                return View("Welcome");
            }
            else
            {
                ViewBag.error = "dang nhap that bai";
                return View("Index");
            }
            
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            Debug.WriteLine(HttpContext.Session.GetString("username"));
            //redirecttoaction giup minh quay lai action nao do trong controller
            return RedirectToAction("Login", "demo");
        }

    }
}