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
            
            Response.Cookies.Append(Key, Value,option);
            return View("Index");
        }
    }
}
