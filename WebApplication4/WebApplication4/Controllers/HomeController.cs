using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("xxx")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}