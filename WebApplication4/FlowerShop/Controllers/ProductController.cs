using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("flowers")]
        public IActionResult Flowers()
        {
            return View("Flowers");
        }

        [Route("specialgifts")]
        public IActionResult SpecialGifts()
        {
            return View("SpecialGifts");
        }
    }
}