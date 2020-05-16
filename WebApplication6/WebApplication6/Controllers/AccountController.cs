using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        //injection
        public AccountController(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            Account account = new Account() { 
                Id = 123,
                Username = "acc1",
                Role = "r3"
            };

            return View("Index", account);
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(Account account, IFormFile namePhoto, List<IFormFile> namePhotos)
        {
            Debug.WriteLine("Account Info");
            Debug.WriteLine("Username: " + account.Username);
            Debug.WriteLine("Password: " + account.Password);

            //upload file
            //namePhoto duoc map tu Index.cshtml   
            if (namePhoto != null)
            {
                Debug.WriteLine("Filename : " + namePhoto.FileName);
                Debug.WriteLine("Filesize : " + namePhoto.Length);
                Debug.WriteLine("Filetype : " + namePhoto.ContentType);
                string path = Path.Combine(this.webHostEnvironment.WebRootPath, "images", namePhoto.FileName);
                namePhoto.CopyTo(new FileStream(path, FileMode.Create));
                account.Photo = namePhoto.FileName;
            }
            
            //upload nhieu file
            if (namePhotos != null)
            {
                Debug.WriteLine("Files: " + namePhotos.Count);
                foreach (var file in namePhotos)
                {
                    Debug.WriteLine("Filename : " + file.FileName);
                    Debug.WriteLine("Filesize : " + file.Length);
                    Debug.WriteLine("Filetype : " + file.ContentType);
                    string path = Path.Combine(this.webHostEnvironment.WebRootPath, "images", file.FileName);
                    file.CopyTo(new FileStream(path, FileMode.Create));
                    account.Photo = file.FileName;
                }
            }
            return View("Success");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Account account)
        {
            Account account1 = new Account() { Username = "acc1", Password = "123" };
            if (account1.Password == account.Password && account1.Username == account.Username)
            {
                return View("Success");
            }
            return View("Error");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            Account account = new Account();
            return View("Login",account);
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("login", "account");
        }
    }
}