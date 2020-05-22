using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_middleware.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/invoice")]
    public class InvoiceController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}