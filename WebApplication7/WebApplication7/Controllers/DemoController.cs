using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("username", "acc1");
            HttpContext.Session.SetInt32("age", 18);
            return View();
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                Debug.WriteLine("Sesstion username : " + username);
            }
            else
            {
                Debug.WriteLine("Session is null");
            }

            if (HttpContext.Session.GetInt32("age") != null)
            {
                int age = HttpContext.Session.GetInt32("age").Value;
                Debug.WriteLine("session age " + age);
            }
            else
            {
                Debug.WriteLine("session is null");
            }
            return View();
        }
    }
}