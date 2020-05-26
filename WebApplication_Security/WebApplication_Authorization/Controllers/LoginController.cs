using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Authorization.Models;
using WebApplication_Authorization.Security;

namespace WebApplication_Authorization.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private DbSession18 db;
        private SecurityManager securityManager = new SecurityManager();

        public LoginController(DbSession18 _db)
        {
            db = _db;
        }

        [HttpGet]
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {

            return View("Index");
        }

        [HttpPost]
        [Route("index")]
        [Route("")]
        public IActionResult Index(Account account)
        {
            if (Check(account.Username, account.Password) != null)
            {

                var acc = db.Account.SingleOrDefault(a => a.Username.Equals(account.Username));
                securityManager.SignIn(HttpContext, acc);
                //HttpContext.Session.SetString("username", account.Username);
                return RedirectToAction("Welcome", "login");
            }
            else
            {
                ViewBag.error = "Invalid";
                return View("Index");
            }

        }

        private Account Check(string username, string password)
        {
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username));
            if (account != null)
            {
                if (password.Equals(account.Password))
                {
                    return account;
                }
            }
            return null;
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            securityManager.SignOut(HttpContext);
            return RedirectToAction("Index", "login");
        }

        [Route("welcome")]
        public IActionResult Welcome()
        {

            //HttpContext.Session.Remove("username");
            return View("Welcome");
        }

        [Route("accessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }


       

       


        
    }
}