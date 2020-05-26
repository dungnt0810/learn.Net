using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Authorization.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View("index");
        }

        [Authorize(Roles = "SuperAdmin")]
        [Route("work1")]
        public IActionResult Work1()
        {
            return View("work1");
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [Route("work2")]
        public IActionResult Work2()
        {
            return View("work2");
        }

        [Authorize(Roles = "SuperAdmin,Admin,Employee")]
        [Route("work3")]
        public IActionResult Work3()
        {
            return View("work3");
        }
    }
}