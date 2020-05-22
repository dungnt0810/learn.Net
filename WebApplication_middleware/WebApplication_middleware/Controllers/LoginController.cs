using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_middleware.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            if (username.Equals("abc") && password.Equals("123"))
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("index", "customer", new { area = "admin" });
            }
            else
            {
                ViewBag.error = "Invalid";
                return View("Index");
            }

        }

        [Route("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("login", "account");
        }
    }
}