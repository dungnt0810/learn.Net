using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication9_EF.Models;

namespace WebApplication9_EF.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private Session9DBContext db;

        public AccountController(Session9DBContext _db)
        {
            db = _db;
        }

        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.accounts = db.Account.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var account = new Account();
            return View("Add");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Account account)
        {
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            db.Account.Add(account);
            db.SaveChanges();
            return RedirectToAction("Index", "account");
        }


        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.Account.Remove(db.Account.Find(id));
            db.SaveChanges();
            return RedirectToAction("index", "account");
        }

        [Route("edit/{id}")]
        public IActionResult Edit(int id, Account account)
        {
            if (account.Password == null)
            {
                var currentAccount = db.Account.AsNoTracking().SingleOrDefault(a => a.Id == id);
                account.Password = currentAccount.Password;
            }
            else
            {
                account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            }
            db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index", "account");
        }

        [Route("search")]
        public IActionResult Search([FromQuery(Name = "keyword")] string keyword)
        {
            ViewBag.keyword = keyword;
            ViewBag.accounts = db.Account.Where(a => a.FullName.Contains(keyword)).ToList();
            return View("Index");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Account account)
        {
            if (Check(account.Username, account.Password) != null)
            {
                HttpContext.Session.SetString("username", account.Username);
                return View("welcome");
            }
            else
            {
                ViewBag.error = "Invalid";
                return View("Login");
            }
            
        }

        private Account Check(string username, string password)
        {
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username));
            if(account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
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
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login", "account");
        }
    }
}