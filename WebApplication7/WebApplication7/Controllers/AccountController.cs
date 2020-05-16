using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var account = new Account();
            return View("Index", account);
        }

        [Route("save")]
        [HttpPost]
        public IActionResult Save(Account account)
        {
            //Custom Validation
            if (account.Username != null && account.Username.Equals("abc"))
            {
                ModelState.AddModelError("Username", "Exists");
            }

            if (ModelState.IsValid)
            {
                Debug.WriteLine("account " + account.Username);
                Debug.WriteLine("account " + account.Password);
                return View("Success");
            }
            else
            {
                return View("Index");
            }
        }
    }
}