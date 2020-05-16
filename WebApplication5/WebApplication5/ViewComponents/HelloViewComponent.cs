using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.ViewComponents
{
    [ViewComponent(Name = "Hello")]
    public class HelloViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //ham nay xu ly bat dong bo
            string name = "abc";
            ViewBag.age = 20;
            ViewBag.price = 1.22;
            return View("Index", name);
        }
    }
}
