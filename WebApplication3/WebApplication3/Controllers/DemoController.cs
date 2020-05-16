using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("xxx")]
    public class DemoController : Controller
    {
        //localhost:port/xxx
        //controller có cái [Route("~/")] là được chạy mặc định và cái này là duy nhất
        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        //localhost:port/xxx/index2
        [Route("index2")]
        public IActionResult Index2()
        {
            return View("Index2");
        }

        [Route("index3/{id}")]
        public IActionResult Index3(string id)
        {
            Debug.WriteLine("id : " + id);
            return View("Index3");
        }

        [Route("index4/{id}/{str}")]
        public IActionResult Index4(int id, string str)
        {
            Debug.WriteLine("id : " + id + " str :"+ str);
            return View("Index4");
        }

        [Route("index5")]
        public IActionResult Index5([FromQuery(Name = "id1")] int id1, [FromQuery(Name = "id2")] int id2)
        {
            Debug.WriteLine("id 1: " + id1 + " id2 :" + id2);
            return View("Index5");
        }

        [Route("index7")]
        public IActionResult Index7()
        {
            int id1 = int.Parse(HttpContext.Request.Query["id1"].ToString());
            int id2 = int.Parse(HttpContext.Request.Query["id1"].ToString());
            Debug.WriteLine("id 1: " + id1 + " id2 :" + id2);
            return View("Index7");
        }
    }
}