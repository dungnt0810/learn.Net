using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9_FlowerShop.Models;

namespace WebApplication9_FlowerShop.ViewComponents
{
    [ViewComponent(Name = "Category")]
    public class CategoryViewComponent : ViewComponent
    {
        private Session9DBContext db;

        public CategoryViewComponent(Session9DBContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Categories = db.Category.ToList();
            return View("Index");
        }
    }
}
