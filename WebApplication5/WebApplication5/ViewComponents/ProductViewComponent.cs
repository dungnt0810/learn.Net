using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.ViewComponents
{
    [ViewComponent(Name = "Product")]
    public class ProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id = "p01", Name = "Name 1", Price = 11.1},
                new Product{Id = "p02", Name = "Name 2", Price = 12.1},
                new Product{Id = "p03", Name = "Name 3", Price = 13.1},
            };
            ViewBag.products = products;
            return View("Index");
        }
    }
}
