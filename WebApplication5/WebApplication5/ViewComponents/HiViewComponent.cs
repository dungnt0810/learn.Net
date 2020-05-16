using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.ViewComponents
{
    [ViewComponent(Name = "Hi")]
    public class HiViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View("Index");
    }
}
