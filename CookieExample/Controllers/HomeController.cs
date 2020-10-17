using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CookieExample.Models;
using Microsoft.AspNetCore.Http;

namespace CookieExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string Key = "MySessionCookie";
        string Value = "MyCookieValue";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            string Key = "MySessionCookie";
            string Value = "MyCookieValue";
            CookieOptions option = new CookieOptions();
            //option.IsEssential = true;
            option.SameSite = SameSiteMode.None;
            option.Secure = true;
            Response.Cookies.Append(Key, Value,option);
            return View("Index");
        }
        public IActionResult Remove()
        {
            CookieOptions option = new CookieOptions();
            //option.IsEssential = true;
            option.SameSite = SameSiteMode.None;
            option.Secure = true;
            Response.Cookies.Delete(Key,option);
            return View("Index");
        }
    }
}
